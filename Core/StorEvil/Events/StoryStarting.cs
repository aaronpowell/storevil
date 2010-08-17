﻿using System;
using StorEvil.Core;

namespace StorEvil.Events
{
    [Serializable]
    public class StoryStarting
    {
        public Story Story;
    }

    [Serializable]
    public class StoryFinished
    {
        public Story Story;
    }
}