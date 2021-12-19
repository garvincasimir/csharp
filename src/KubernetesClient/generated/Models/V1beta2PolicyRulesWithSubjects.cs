// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// PolicyRulesWithSubjects prescribes a test that applies to a request to an
        /// apiserver. The test considers the subject making the request, the verb being
        /// requested, and the resource to be acted upon. This PolicyRulesWithSubjects
        /// matches a request if and only if both (a) at least one member of subjects
        /// matches the request and (b) at least one member of resourceRules or
        /// nonResourceRules matches the request.
    /// </summary>
    public partial class V1beta2PolicyRulesWithSubjects
    {
        /// <summary>
        /// Initializes a new instance of the V1beta2PolicyRulesWithSubjects class.
        /// </summary>
        public V1beta2PolicyRulesWithSubjects()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta2PolicyRulesWithSubjects class.
        /// </summary>
        /// <param name="subjects">
        /// subjects is the list of normal user, serviceaccount, or group that this rule
        /// cares about. There must be at least one member in this slice. A slice that
        /// includes both the system:authenticated and system:unauthenticated user groups
        /// matches every request. Required.
        /// </param>
        /// <param name="nonResourceRules">
        /// `nonResourceRules` is a list of NonResourcePolicyRules that identify matching
        /// requests according to their verb and the target non-resource URL.
        /// </param>
        /// <param name="resourceRules">
        /// `resourceRules` is a slice of ResourcePolicyRules that identify matching
        /// requests according to their verb and the target resource. At least one of
        /// `resourceRules` and `nonResourceRules` has to be non-empty.
        /// </param>
        public V1beta2PolicyRulesWithSubjects(IList<V1beta2Subject> subjects, IList<V1beta2NonResourcePolicyRule> nonResourceRules = null, IList<V1beta2ResourcePolicyRule> resourceRules = null)
        {
            NonResourceRules = nonResourceRules;
            ResourceRules = resourceRules;
            Subjects = subjects;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// `nonResourceRules` is a list of NonResourcePolicyRules that identify matching
        /// requests according to their verb and the target non-resource URL.
        /// </summary>
        [JsonPropertyName("nonResourceRules")]
        public IList<V1beta2NonResourcePolicyRule> NonResourceRules { get; set; }

        /// <summary>
        /// `resourceRules` is a slice of ResourcePolicyRules that identify matching
        /// requests according to their verb and the target resource. At least one of
        /// `resourceRules` and `nonResourceRules` has to be non-empty.
        /// </summary>
        [JsonPropertyName("resourceRules")]
        public IList<V1beta2ResourcePolicyRule> ResourceRules { get; set; }

        /// <summary>
        /// subjects is the list of normal user, serviceaccount, or group that this rule
        /// cares about. There must be at least one member in this slice. A slice that
        /// includes both the system:authenticated and system:unauthenticated user groups
        /// matches every request. Required.
        /// </summary>
        [JsonPropertyName("subjects")]
        public IList<V1beta2Subject> Subjects { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (NonResourceRules != null){
                foreach(var obj in NonResourceRules)
                {
                    obj.Validate();
                }
            }
            if (ResourceRules != null){
                foreach(var obj in ResourceRules)
                {
                    obj.Validate();
                }
            }
            if (Subjects != null){
                foreach(var obj in Subjects)
                {
                    obj.Validate();
                }
            }
        }
    }
}