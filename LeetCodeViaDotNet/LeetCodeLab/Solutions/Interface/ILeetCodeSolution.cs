using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CommonUtils.UnitTest;

namespace LeetCodeLab.Solutions.Interface
{
    public interface ILeetCodeSolution
    {
        void SetUpExtraData<T>(T data);

        void SetUpTestCase(TestCase testCase);

        void Execute();
    }
}
