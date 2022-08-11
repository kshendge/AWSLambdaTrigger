using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AWSLambdaTrigger
{
    public class Function
    {

        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>

        public string FunctionHandler(string input, ILambdaContext context)
        {
            context.Logger.Log("Hello from lambda :" + context.FunctionName +"\n");
            context.Logger.Log($"Logs will be write to following. {nameof(context.LogGroupName)} : {context.LogGroupName}, {nameof(context.LogStreamName)} : {context.LogStreamName}");
            context.Logger.Log("Function Name :" + context.FunctionName + "\n");
            context.Logger.Log("Remaining Time" + context.RemainingTime + "\n");
            context.Logger.Log("log GroupName" + context.LogGroupName + "\n");

            return input?.ToUpper();

        }
    }
}
