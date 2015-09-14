﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Library;
using Microsoft.OData.Edm.Library.Expressions;
using Microsoft.Restier.Core;
using Microsoft.Restier.Core.Model;
using Microsoft.Restier.EntityFramework;
using Microsoft.Restier.WebApi.Test.Services.Trippin.Models;

namespace Microsoft.Restier.WebApi.Test.Services.Trippin.Domain
{
    [Test]
    public class TrippinDomain : DbDomain<TrippinModel>
    {
        public TrippinModel Context { get { return DbContext; } }

        public Person Me { get; }

        private IQueryable<Person> PeopleWithFriends
        {
            get { return Context.People.Include("Friends"); }
        }

        /// <summary>
        /// Implements an action import.
        /// TODO: This method is only for building the model.
        /// </summary>
        [Action(Namespace = "Microsoft.Restier.WebApi.Test.Services.Trippin.Models")]
        public void ResetDataSource()
        {
            TrippinModel.ResetDataSource();
        }

        /// <summary>
        /// Action import - clean up all the expired trips.
        /// </summary>
        [Action(Namespace = "Microsoft.Restier.WebApi.Test.Services.Trippin.Models")]
        public void CleanUpExpiredTrips()
        {
            // DO NOT ACTUALLY REMOVE THE TRIPS.
        }

        /// <summary>
        /// Bound action - set the end-up time of a trip.
        /// </summary>
        /// <param name="key">The trip to update.</param>
        /// <returns>The trip updated.</returns>
        [Action(Namespace = "Microsoft.Restier.WebApi.Test.Services.Trippin.Models")]
        public Trip EndTrip(Trip trip)
        {
            // DO NOT ACTUALLY UPDATE THE TRIP.
            return trip;
        }

        /// <summary>
        /// Bound function - gets the number of friends of a person.
        /// </summary>
        /// <param name="key">The key of the binding person.</param>
        /// <returns>The number of friends of the person.</returns>
        public int GetNumberOfFriends(int key)
        {
            var person = PeopleWithFriends.Single(p => p.PersonId == key);
            return person.Friends == null ? 0 : person.Friends.Count;
        }

        /// <summary>
        /// Function import - gets the person with most friends.
        /// </summary>
        /// <returns>The person with most friends.</returns>
        public Person GetPersonWithMostFriends()
        {
            Person result = null;

            foreach (var person in PeopleWithFriends)
            {
                if (person.Friends == null)
                {
                    continue;
                }

                if (result == null)
                {
                    result = person;
                }

                if (person.Friends.Count > result.Friends.Count)
                {
                    result = person;
                }
            }

            return result;
        }

        /// <summary>
        /// Function import - gets people with at least n friends.
        /// </summary>
        /// <param name="n">The minimum number of friends.</param>
        /// <returns>People with at least n friends.</returns>
        public IEnumerable<Person> GetPeopleWithFriendsAtLeast(int n)
        {
            foreach (var person in PeopleWithFriends)
            {
                if (person.Friends == null)
                {
                    continue;
                }

                if (person.Friends.Count >= n)
                {
                    yield return person;
                }
            }
        }
    }

    public class TestAttribute : DomainParticipantAttribute
    {
        public override void Configure(
            DomainConfiguration configuration,
            Type type)
        {
            configuration.AddHookHandler<IModelBuilder>(new CustomExtender());
        }
    }

    public class CustomExtender : IModelBuilder, IDelegateHookHandler<IModelBuilder>
    {
        public IModelBuilder InnerHandler { get; set; }

        public async Task<IEdmModel> GetModelAsync(InvocationContext context, CancellationToken cancellationToken)
        {
            EdmModel model = null;
            if (this.InnerHandler != null)
            {
                model = await this.InnerHandler.GetModelAsync(context, cancellationToken)as EdmModel;
            }

            var entityContainer = (EdmEntityContainer)model.EntityContainer;
            var personType = (IEdmEntityType)model
                .FindDeclaredType("Microsoft.Restier.WebApi.Test.Services.Trippin.Models.Person");
            var personTypeReference = new EdmEntityTypeReference(personType, false);
            var people = entityContainer.FindEntitySet("People");

            var getNumberOfFriends = new EdmFunction(
                "Microsoft.Restier.WebApi.Test.Services.Trippin.Models",
                "GetNumberOfFriends",
                EdmCoreModel.Instance.GetInt32(false),
                isBound: true,
                entitySetPathExpression: null,
                isComposable: true);
            getNumberOfFriends.AddParameter("person", personTypeReference);
            model.AddElement(getNumberOfFriends);

            var getPersonWithMostFriends = new EdmFunction(
                "Microsoft.Restier.WebApi.Test.Services.Trippin.Models",
                "GetPersonWithMostFriends",
                personTypeReference,
                isBound: false,
                entitySetPathExpression: null,
                isComposable: true);
            model.AddElement(getPersonWithMostFriends);
            entityContainer.AddFunctionImport(
                "GetPersonWithMostFriends",
                getPersonWithMostFriends,
                new EdmEntitySetReferenceExpression(people));

            var getPeopleWithFriendsAtLeast = new EdmFunction(
                "Microsoft.Restier.WebApi.Test.Services.Trippin.Models",
                "GetPeopleWithFriendsAtLeast",
                EdmCoreModel.GetCollection(personTypeReference),
                isBound: false,
                entitySetPathExpression: null,
                isComposable: true);
            getPeopleWithFriendsAtLeast.AddParameter("n", EdmCoreModel.Instance.GetInt32(false));
            model.AddElement(getPeopleWithFriendsAtLeast);
            entityContainer.AddFunctionImport(
                "GetPeopleWithFriendsAtLeast",
                getPeopleWithFriendsAtLeast,
                new EdmEntitySetReferenceExpression(people));

            return model;
        }
    }
}