// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Personalizer
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Evaluations.
    /// </summary>
    public static partial class EvaluationsExtensions
    {
            /// <summary>
            /// Get Evaluation.
            /// </summary>
            /// <remarks>
            /// Get the evaluation associated with the Id.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='evaluationId'>
            /// Id of the evaluation.
            /// </param>
            public static Evaluation Get(this IEvaluations operations, string evaluationId)
            {
                return operations.GetAsync(evaluationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get Evaluation.
            /// </summary>
            /// <remarks>
            /// Get the evaluation associated with the Id.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='evaluationId'>
            /// Id of the evaluation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Evaluation> GetAsync(this IEvaluations operations, string evaluationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(evaluationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get Evaluation.
            /// </summary>
            /// <remarks>
            /// Get the evaluation associated with the Id.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='evaluationId'>
            /// Id of the evaluation.
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<Evaluation> GetWithHttpMessages(this IEvaluations operations, string evaluationId, Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(evaluationId, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete Evaluation.
            /// </summary>
            /// <remarks>
            /// Delete the evaluation associated with the Id.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='evaluationId'>
            /// Id of the evaluation to delete.
            /// </param>
            public static void Delete(this IEvaluations operations, string evaluationId)
            {
                operations.DeleteAsync(evaluationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete Evaluation.
            /// </summary>
            /// <remarks>
            /// Delete the evaluation associated with the Id.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='evaluationId'>
            /// Id of the evaluation to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IEvaluations operations, string evaluationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(evaluationId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Delete Evaluation.
            /// </summary>
            /// <remarks>
            /// Delete the evaluation associated with the Id.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='evaluationId'>
            /// Id of the evaluation to delete.
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse DeleteWithHttpMessages(this IEvaluations operations, string evaluationId, Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.DeleteWithHttpMessagesAsync(evaluationId, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List Evaluations.
            /// </summary>
            /// <remarks>
            /// List all the submitted evaluations.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<Evaluation> List(this IEvaluations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List Evaluations.
            /// </summary>
            /// <remarks>
            /// List all the submitted evaluations.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Evaluation>> ListAsync(this IEvaluations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List Evaluations.
            /// </summary>
            /// <remarks>
            /// List all the submitted evaluations.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<IList<Evaluation>> ListWithHttpMessages(this IEvaluations operations, Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.ListWithHttpMessagesAsync(customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create Evaluation.
            /// </summary>
            /// <remarks>
            /// Submit a new evaluation job.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='evaluation'>
            /// The evaluation job definition.
            /// </param>
            public static Evaluation Create(this IEvaluations operations, EvaluationContract evaluation)
            {
                return operations.CreateAsync(evaluation).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create Evaluation.
            /// </summary>
            /// <remarks>
            /// Submit a new evaluation job.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='evaluation'>
            /// The evaluation job definition.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Evaluation> CreateAsync(this IEvaluations operations, EvaluationContract evaluation, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(evaluation, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create Evaluation.
            /// </summary>
            /// <remarks>
            /// Submit a new evaluation job.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='evaluation'>
            /// The evaluation job definition.
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<Evaluation,EvaluationsCreateHeaders> CreateWithHttpMessages(this IEvaluations operations, EvaluationContract evaluation, Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.CreateWithHttpMessagesAsync(evaluation, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}