﻿namespace Nivaes.DataTestGenerator
{
    using System.Collections.Generic;
    using System.Reflection;
    using Xunit;
    using Xunit.Sdk;

    public sealed class GenerateIntTheoryData : TheoryData<int>
    {
        public GenerateIntTheoryData()
        {
            base.Add(GenericGenerator.Instance.GenerateInt());
        }

        public GenerateIntTheoryData(int dataNumber)
        {
            for (int i = 0; i < dataNumber; i++)
            {
                base.Add(GenericGenerator.Instance.GenerateInt());
            }
        }

        public GenerateIntTheoryData(int dataNumber, int maxSize, int minSize)
        {
            for (int i = 0; i < dataNumber; i++)
            {
                base.Add(GenericGenerator.Instance.GenerateInt(maxSize, minSize));
            }
        }
    }
}
