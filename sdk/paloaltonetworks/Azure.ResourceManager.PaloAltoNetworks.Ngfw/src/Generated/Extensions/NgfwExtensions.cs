// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.PaloAltoNetworks.Ngfw. </summary>
    public static partial class NgfwExtensions
    {
        private static ResourceGroupResourceExtensionClient GetResourceGroupResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new ResourceGroupResourceExtensionClient(client, resource.Id);
            });
        }

        private static ResourceGroupResourceExtensionClient GetResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new ResourceGroupResourceExtensionClient(client, scope);
            });
        }

        private static SubscriptionResourceExtensionClient GetSubscriptionResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new SubscriptionResourceExtensionClient(client, resource.Id);
            });
        }

        private static SubscriptionResourceExtensionClient GetSubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new SubscriptionResourceExtensionClient(client, scope);
            });
        }

        private static TenantResourceExtensionClient GetTenantResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new TenantResourceExtensionClient(client, resource.Id);
            });
        }

        private static TenantResourceExtensionClient GetTenantResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new TenantResourceExtensionClient(client, scope);
            });
        }
        #region GlobalRulestackResource
        /// <summary>
        /// Gets an object representing a <see cref="GlobalRulestackResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="GlobalRulestackResource.CreateResourceIdentifier" /> to create a <see cref="GlobalRulestackResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GlobalRulestackResource" /> object. </returns>
        public static GlobalRulestackResource GetGlobalRulestackResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                GlobalRulestackResource.ValidateResourceId(id);
                return new GlobalRulestackResource(client, id);
            }
            );
        }
        #endregion

        #region CertificateObjectGlobalRulestackResource
        /// <summary>
        /// Gets an object representing a <see cref="CertificateObjectGlobalRulestackResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CertificateObjectGlobalRulestackResource.CreateResourceIdentifier" /> to create a <see cref="CertificateObjectGlobalRulestackResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CertificateObjectGlobalRulestackResource" /> object. </returns>
        public static CertificateObjectGlobalRulestackResource GetCertificateObjectGlobalRulestackResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                CertificateObjectGlobalRulestackResource.ValidateResourceId(id);
                return new CertificateObjectGlobalRulestackResource(client, id);
            }
            );
        }
        #endregion

        #region FqdnListGlobalRulestackResource
        /// <summary>
        /// Gets an object representing a <see cref="FqdnListGlobalRulestackResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FqdnListGlobalRulestackResource.CreateResourceIdentifier" /> to create a <see cref="FqdnListGlobalRulestackResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FqdnListGlobalRulestackResource" /> object. </returns>
        public static FqdnListGlobalRulestackResource GetFqdnListGlobalRulestackResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FqdnListGlobalRulestackResource.ValidateResourceId(id);
                return new FqdnListGlobalRulestackResource(client, id);
            }
            );
        }
        #endregion

        #region PostRulesResource
        /// <summary>
        /// Gets an object representing a <see cref="PostRulesResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostRulesResource.CreateResourceIdentifier" /> to create a <see cref="PostRulesResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostRulesResource" /> object. </returns>
        public static PostRulesResource GetPostRulesResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PostRulesResource.ValidateResourceId(id);
                return new PostRulesResource(client, id);
            }
            );
        }
        #endregion

        #region PrefixListGlobalRulestackResource
        /// <summary>
        /// Gets an object representing a <see cref="PrefixListGlobalRulestackResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrefixListGlobalRulestackResource.CreateResourceIdentifier" /> to create a <see cref="PrefixListGlobalRulestackResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrefixListGlobalRulestackResource" /> object. </returns>
        public static PrefixListGlobalRulestackResource GetPrefixListGlobalRulestackResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PrefixListGlobalRulestackResource.ValidateResourceId(id);
                return new PrefixListGlobalRulestackResource(client, id);
            }
            );
        }
        #endregion

        #region PreRulesResource
        /// <summary>
        /// Gets an object representing a <see cref="PreRulesResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PreRulesResource.CreateResourceIdentifier" /> to create a <see cref="PreRulesResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PreRulesResource" /> object. </returns>
        public static PreRulesResource GetPreRulesResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PreRulesResource.ValidateResourceId(id);
                return new PreRulesResource(client, id);
            }
            );
        }
        #endregion

        #region FirewallResource
        /// <summary>
        /// Gets an object representing a <see cref="FirewallResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FirewallResource.CreateResourceIdentifier" /> to create a <see cref="FirewallResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FirewallResource" /> object. </returns>
        public static FirewallResource GetFirewallResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FirewallResource.ValidateResourceId(id);
                return new FirewallResource(client, id);
            }
            );
        }
        #endregion

        #region LocalRulestackResource
        /// <summary>
        /// Gets an object representing a <see cref="LocalRulestackResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LocalRulestackResource.CreateResourceIdentifier" /> to create a <see cref="LocalRulestackResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="LocalRulestackResource" /> object. </returns>
        public static LocalRulestackResource GetLocalRulestackResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                LocalRulestackResource.ValidateResourceId(id);
                return new LocalRulestackResource(client, id);
            }
            );
        }
        #endregion

        #region CertificateObjectLocalRulestackResource
        /// <summary>
        /// Gets an object representing a <see cref="CertificateObjectLocalRulestackResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CertificateObjectLocalRulestackResource.CreateResourceIdentifier" /> to create a <see cref="CertificateObjectLocalRulestackResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CertificateObjectLocalRulestackResource" /> object. </returns>
        public static CertificateObjectLocalRulestackResource GetCertificateObjectLocalRulestackResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                CertificateObjectLocalRulestackResource.ValidateResourceId(id);
                return new CertificateObjectLocalRulestackResource(client, id);
            }
            );
        }
        #endregion

        #region FqdnListLocalRulestackResource
        /// <summary>
        /// Gets an object representing a <see cref="FqdnListLocalRulestackResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FqdnListLocalRulestackResource.CreateResourceIdentifier" /> to create a <see cref="FqdnListLocalRulestackResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FqdnListLocalRulestackResource" /> object. </returns>
        public static FqdnListLocalRulestackResource GetFqdnListLocalRulestackResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FqdnListLocalRulestackResource.ValidateResourceId(id);
                return new FqdnListLocalRulestackResource(client, id);
            }
            );
        }
        #endregion

        #region LocalRulesResource
        /// <summary>
        /// Gets an object representing a <see cref="LocalRulesResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LocalRulesResource.CreateResourceIdentifier" /> to create a <see cref="LocalRulesResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="LocalRulesResource" /> object. </returns>
        public static LocalRulesResource GetLocalRulesResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                LocalRulesResource.ValidateResourceId(id);
                return new LocalRulesResource(client, id);
            }
            );
        }
        #endregion

        #region PrefixListResource
        /// <summary>
        /// Gets an object representing a <see cref="PrefixListResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrefixListResource.CreateResourceIdentifier" /> to create a <see cref="PrefixListResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrefixListResource" /> object. </returns>
        public static PrefixListResource GetPrefixListResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PrefixListResource.ValidateResourceId(id);
                return new PrefixListResource(client, id);
            }
            );
        }
        #endregion

        /// <summary> Gets a collection of FirewallResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of FirewallResources and their operations over a FirewallResource. </returns>
        public static FirewallResourceCollection GetFirewallResources(this ResourceGroupResource resourceGroupResource)
        {
            return GetResourceGroupResourceExtensionClient(resourceGroupResource).GetFirewallResources();
        }

        /// <summary>
        /// Get a FirewallResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/firewalls/{firewallName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firewalls_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="firewallName"> Firewall resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<FirewallResource>> GetFirewallResourceAsync(this ResourceGroupResource resourceGroupResource, string firewallName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetFirewallResources().GetAsync(firewallName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a FirewallResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/firewalls/{firewallName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firewalls_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="firewallName"> Firewall resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<FirewallResource> GetFirewallResource(this ResourceGroupResource resourceGroupResource, string firewallName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetFirewallResources().Get(firewallName, cancellationToken);
        }

        /// <summary> Gets a collection of LocalRulestackResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of LocalRulestackResources and their operations over a LocalRulestackResource. </returns>
        public static LocalRulestackResourceCollection GetLocalRulestackResources(this ResourceGroupResource resourceGroupResource)
        {
            return GetResourceGroupResourceExtensionClient(resourceGroupResource).GetLocalRulestackResources();
        }

        /// <summary>
        /// Get a LocalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalRulestacks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="localRulestackName"> LocalRulestack resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="localRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="localRulestackName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<LocalRulestackResource>> GetLocalRulestackResourceAsync(this ResourceGroupResource resourceGroupResource, string localRulestackName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetLocalRulestackResources().GetAsync(localRulestackName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a LocalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalRulestacks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="localRulestackName"> LocalRulestack resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="localRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="localRulestackName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<LocalRulestackResource> GetLocalRulestackResource(this ResourceGroupResource resourceGroupResource, string localRulestackName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetLocalRulestackResources().Get(localRulestackName, cancellationToken);
        }

        /// <summary>
        /// List FirewallResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/PaloAltoNetworks.Cloudngfw/firewalls</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firewalls_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FirewallResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<FirewallResource> GetFirewallResourcesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetFirewallResourcesAsync(cancellationToken);
        }

        /// <summary>
        /// List FirewallResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/PaloAltoNetworks.Cloudngfw/firewalls</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firewalls_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FirewallResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<FirewallResource> GetFirewallResources(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetFirewallResources(cancellationToken);
        }

        /// <summary>
        /// List LocalRulestackResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalRulestacks_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LocalRulestackResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<LocalRulestackResource> GetLocalRulestackResourcesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetLocalRulestackResourcesAsync(cancellationToken);
        }

        /// <summary>
        /// List LocalRulestackResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalRulestacks_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LocalRulestackResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<LocalRulestackResource> GetLocalRulestackResources(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetLocalRulestackResources(cancellationToken);
        }

        /// <summary> Gets a collection of GlobalRulestackResources in the TenantResource. </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of GlobalRulestackResources and their operations over a GlobalRulestackResource. </returns>
        public static GlobalRulestackResourceCollection GetGlobalRulestackResources(this TenantResource tenantResource)
        {
            return GetTenantResourceExtensionClient(tenantResource).GetGlobalRulestackResources();
        }

        /// <summary>
        /// Get a GlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<GlobalRulestackResource>> GetGlobalRulestackResourceAsync(this TenantResource tenantResource, string globalRulestackName, CancellationToken cancellationToken = default)
        {
            return await tenantResource.GetGlobalRulestackResources().GetAsync(globalRulestackName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a GlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<GlobalRulestackResource> GetGlobalRulestackResource(this TenantResource tenantResource, string globalRulestackName, CancellationToken cancellationToken = default)
        {
            return tenantResource.GetGlobalRulestackResources().Get(globalRulestackName, cancellationToken);
        }
    }
}
