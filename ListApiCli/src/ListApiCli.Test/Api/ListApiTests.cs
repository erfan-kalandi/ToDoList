/*
 * DatabaseService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using ListApiCli.Client;
using ListApiCli.Api;
// uncomment below to import models
//using ListApiCli.Model;

namespace ListApiCli.Test.Api
{
    /// <summary>
    ///  Class for testing ListApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ListApiTests : IDisposable
    {
        private ListApi instance;

        public ListApiTests()
        {
            instance = new ListApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ListApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ListApi
            //Assert.IsType<ListApi>(instance);
        }

        /// <summary>
        /// Test ListGet
        /// </summary>
        [Fact]
        public void ListGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListGet();
            //Assert.IsType<List<ToDoItems>>(response);
        }

        /// <summary>
        /// Test ListListAddItemPost
        /// </summary>
        [Fact]
        public void ListListAddItemPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ToDoItems toDoItems = null;
            //instance.ListListAddItemPost(toDoItems);
        }

        /// <summary>
        /// Test ListListDeleteIdiDelete
        /// </summary>
        [Fact]
        public void ListListDeleteIdiDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string idi = null;
            //instance.ListListDeleteIdiDelete(idi);
        }

        /// <summary>
        /// Test ListListGetIdGet
        /// </summary>
        [Fact]
        public void ListListGetIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ListListGetIdGet(id);
            //Assert.IsType<ToDoItems>(response);
        }
    }
}