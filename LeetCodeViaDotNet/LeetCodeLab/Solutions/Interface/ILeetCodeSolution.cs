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
        /// <summary>
        /// Set extra data if needed
        /// </summary>
        /// <param name="data"></param>
        /// <typeparam name="T"></typeparam>
        void SetUpExtraData<T>(T data);

        /// <summary>
        /// Execute a Solution main method
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        string Execute(string input);
    }
}
