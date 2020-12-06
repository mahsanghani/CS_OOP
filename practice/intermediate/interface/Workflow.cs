using System;

namespace practice.intermediate.@interface
{
    public class Workflow
    {
        public List<IActivity> Activities { get; }

        public Workflow(List<IActivity> activities)
        {
            Activities = activities;
        }
    }
}
