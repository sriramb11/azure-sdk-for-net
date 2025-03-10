// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Workloads;
using Azure.ResourceManager.Workloads.Models;

namespace Azure.ResourceManager.Workloads.Samples
{
    public partial class Sample_SapApplicationServerInstanceResource
    {
        // SAPApplicationServerInstances_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SAPApplicationServerInstancesGet()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/sapvirtualinstances/SAPApplicationServerInstances_Get.json
            // this example is just showing the usage of "SAPApplicationServerInstances_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapApplicationServerInstanceResource created on azure
            // for more information of creating SapApplicationServerInstanceResource, please refer to the document of SapApplicationServerInstanceResource
            string subscriptionId = "6d875e77-e412-4d7d-9af4-8895278b4443";
            string resourceGroupName = "test-rg";
            string sapVirtualInstanceName = "X00";
            string applicationInstanceName = "app01";
            ResourceIdentifier sapApplicationServerInstanceResourceId = SapApplicationServerInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sapVirtualInstanceName, applicationInstanceName);
            SapApplicationServerInstanceResource sapApplicationServerInstance = client.GetSapApplicationServerInstanceResource(sapApplicationServerInstanceResourceId);

            // invoke the operation
            SapApplicationServerInstanceResource result = await sapApplicationServerInstance.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SapApplicationServerInstanceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // SAPApplicationServerInstances_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_SAPApplicationServerInstancesUpdate()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/sapvirtualinstances/SAPApplicationServerInstances_Update.json
            // this example is just showing the usage of "SAPApplicationServerInstances_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapApplicationServerInstanceResource created on azure
            // for more information of creating SapApplicationServerInstanceResource, please refer to the document of SapApplicationServerInstanceResource
            string subscriptionId = "6d875e77-e412-4d7d-9af4-8895278b4443";
            string resourceGroupName = "test-rg";
            string sapVirtualInstanceName = "X00";
            string applicationInstanceName = "app01";
            ResourceIdentifier sapApplicationServerInstanceResourceId = SapApplicationServerInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sapVirtualInstanceName, applicationInstanceName);
            SapApplicationServerInstanceResource sapApplicationServerInstance = client.GetSapApplicationServerInstanceResource(sapApplicationServerInstanceResourceId);

            // invoke the operation
            SapApplicationServerInstancePatch patch = new SapApplicationServerInstancePatch()
            {
                Tags =
{
["tag1"] = "value1",
},
            };
            ArmOperation<SapApplicationServerInstanceResource> lro = await sapApplicationServerInstance.UpdateAsync(WaitUntil.Completed, patch);
            SapApplicationServerInstanceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SapApplicationServerInstanceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // SAPApplicationServerInstances_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_SAPApplicationServerInstancesDelete()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/sapvirtualinstances/SAPApplicationServerInstances_Delete.json
            // this example is just showing the usage of "SAPApplicationServerInstances_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapApplicationServerInstanceResource created on azure
            // for more information of creating SapApplicationServerInstanceResource, please refer to the document of SapApplicationServerInstanceResource
            string subscriptionId = "6d875e77-e412-4d7d-9af4-8895278b4443";
            string resourceGroupName = "test-rg";
            string sapVirtualInstanceName = "X00";
            string applicationInstanceName = "app01";
            ResourceIdentifier sapApplicationServerInstanceResourceId = SapApplicationServerInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sapVirtualInstanceName, applicationInstanceName);
            SapApplicationServerInstanceResource sapApplicationServerInstance = client.GetSapApplicationServerInstanceResource(sapApplicationServerInstanceResourceId);

            // invoke the operation
            ArmOperation<OperationStatusResult> lro = await sapApplicationServerInstance.DeleteAsync(WaitUntil.Completed);
            OperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Start the SAP Application Server Instance.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task StartInstance_StartTheSAPApplicationServerInstance()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/sapvirtualinstances/SAPApplicationServerInstances_StartInstance.json
            // this example is just showing the usage of "SAPApplicationServerInstances_StartInstance" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapApplicationServerInstanceResource created on azure
            // for more information of creating SapApplicationServerInstanceResource, please refer to the document of SapApplicationServerInstanceResource
            string subscriptionId = "8e17e36c-42e9-4cd5-a078-7b44883414e0";
            string resourceGroupName = "test-rg";
            string sapVirtualInstanceName = "X00";
            string applicationInstanceName = "app01";
            ResourceIdentifier sapApplicationServerInstanceResourceId = SapApplicationServerInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sapVirtualInstanceName, applicationInstanceName);
            SapApplicationServerInstanceResource sapApplicationServerInstance = client.GetSapApplicationServerInstanceResource(sapApplicationServerInstanceResourceId);

            // invoke the operation
            ArmOperation<OperationStatusResult> lro = await sapApplicationServerInstance.StartInstanceAsync(WaitUntil.Completed);
            OperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Stop the SAP Application Server Instance
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task StopInstance_StopTheSAPApplicationServerInstance()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/sapvirtualinstances/SAPApplicationServerInstances_StopInstance.json
            // this example is just showing the usage of "SAPApplicationServerInstances_StopInstance" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapApplicationServerInstanceResource created on azure
            // for more information of creating SapApplicationServerInstanceResource, please refer to the document of SapApplicationServerInstanceResource
            string subscriptionId = "8e17e36c-42e9-4cd5-a078-7b44883414e0";
            string resourceGroupName = "test-rg";
            string sapVirtualInstanceName = "X00";
            string applicationInstanceName = "app01";
            ResourceIdentifier sapApplicationServerInstanceResourceId = SapApplicationServerInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sapVirtualInstanceName, applicationInstanceName);
            SapApplicationServerInstanceResource sapApplicationServerInstance = client.GetSapApplicationServerInstanceResource(sapApplicationServerInstanceResourceId);

            // invoke the operation
            StopRequest body = new StopRequest()
            {
                SoftStopTimeoutSeconds = 0,
            };
            ArmOperation<OperationStatusResult> lro = await sapApplicationServerInstance.StopInstanceAsync(WaitUntil.Completed, body: body);
            OperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
