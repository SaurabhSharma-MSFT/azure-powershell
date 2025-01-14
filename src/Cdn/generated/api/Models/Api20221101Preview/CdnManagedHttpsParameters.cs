// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>
    /// Defines the certificate source parameters using CDN managed certificate for enabling SSL.
    /// </summary>
    public partial class CdnManagedHttpsParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ICdnManagedHttpsParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ICdnManagedHttpsParametersInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ICustomDomainHttpsParameters"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ICustomDomainHttpsParameters __customDomainHttpsParameters = new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.CustomDomainHttpsParameters();

        /// <summary>Defines the source of the SSL certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CertificateSource CertificateSource { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ICustomDomainHttpsParametersInternal)__customDomainHttpsParameters).CertificateSource; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ICustomDomainHttpsParametersInternal)__customDomainHttpsParameters).CertificateSource = value ; }

        /// <summary>Backing field for <see cref="CertificateSourceParameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ICdnCertificateSourceParameters _certificateSourceParameter;

        /// <summary>
        /// Defines the certificate source parameters using CDN managed certificate for enabling SSL.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ICdnCertificateSourceParameters CertificateSourceParameter { get => (this._certificateSourceParameter = this._certificateSourceParameter ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.CdnCertificateSourceParameters()); set => this._certificateSourceParameter = value; }

        /// <summary>Type of certificate used</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CertificateType CertificateSourceParameterCertificateType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ICdnCertificateSourceParametersInternal)CertificateSourceParameter).CertificateType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ICdnCertificateSourceParametersInternal)CertificateSourceParameter).CertificateType = value ; }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string CertificateSourceParameterTypeName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ICdnCertificateSourceParametersInternal)CertificateSourceParameter).TypeName; }

        /// <summary>Internal Acessors for CertificateSourceParameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ICdnCertificateSourceParameters Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ICdnManagedHttpsParametersInternal.CertificateSourceParameter { get => (this._certificateSourceParameter = this._certificateSourceParameter ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.CdnCertificateSourceParameters()); set { {_certificateSourceParameter = value;} } }

        /// <summary>Internal Acessors for CertificateSourceParameterTypeName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ICdnManagedHttpsParametersInternal.CertificateSourceParameterTypeName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ICdnCertificateSourceParametersInternal)CertificateSourceParameter).TypeName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ICdnCertificateSourceParametersInternal)CertificateSourceParameter).TypeName = value; }

        /// <summary>TLS protocol version that will be used for Https</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.MinimumTlsVersion? MinimumTlsVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ICustomDomainHttpsParametersInternal)__customDomainHttpsParameters).MinimumTlsVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ICustomDomainHttpsParametersInternal)__customDomainHttpsParameters).MinimumTlsVersion = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.MinimumTlsVersion)""); }

        /// <summary>Defines the TLS extension protocol that is used for secure delivery.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProtocolType ProtocolType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ICustomDomainHttpsParametersInternal)__customDomainHttpsParameters).ProtocolType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ICustomDomainHttpsParametersInternal)__customDomainHttpsParameters).ProtocolType = value ; }

        /// <summary>Creates an new <see cref="CdnManagedHttpsParameters" /> instance.</summary>
        public CdnManagedHttpsParameters()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__customDomainHttpsParameters), __customDomainHttpsParameters);
            await eventListener.AssertObjectIsValid(nameof(__customDomainHttpsParameters), __customDomainHttpsParameters);
        }
    }
    /// Defines the certificate source parameters using CDN managed certificate for enabling SSL.
    public partial interface ICdnManagedHttpsParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ICustomDomainHttpsParameters
    {
        /// <summary>Type of certificate used</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Type of certificate used",
        SerializedName = @"certificateType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CertificateType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CertificateType CertificateSourceParameterCertificateType { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"",
        SerializedName = @"typeName",
        PossibleTypes = new [] { typeof(string) })]
        string CertificateSourceParameterTypeName { get;  }

    }
    /// Defines the certificate source parameters using CDN managed certificate for enabling SSL.
    internal partial interface ICdnManagedHttpsParametersInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ICustomDomainHttpsParametersInternal
    {
        /// <summary>
        /// Defines the certificate source parameters using CDN managed certificate for enabling SSL.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.ICdnCertificateSourceParameters CertificateSourceParameter { get; set; }
        /// <summary>Type of certificate used</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CertificateType CertificateSourceParameterCertificateType { get; set; }

        string CertificateSourceParameterTypeName { get; set; }

    }
}