﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sep13v1.ViewModels
{
    // Choose unique names for the view model classes
    // Do not re-use the original class name (in the app domain data model)

    // Just the fields that are useful for a lookup list
    public class SubjectList
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        // Or, as an alternative to the above two fields...
        public string CodeAndName { get { return Code + " - " + Name; } }
    }

    // A template for displaying public properties, or adding a 'new' Program object
    // Notice that there's no 'Id' field, because that's auto-generated by the data store
    public class SubjectPublic
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    // For get-some and get-one tasks
    // For this entity, can also be used for editing
    // (for this simple class, it includes all properties)
    public class SubjectFull : SubjectPublic
    {
        public int Id { get; set; }
    }

}