using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace ReSharper101WCF
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        // 20161RTM: Inspection "WCF operation marked as one way with return value" + QF
        [OperationContract(IsOneWay = true)]
        CompositeType GetDataUsingDataContract(CompositeType composite);
    }

    // 20161RTM: Inspection "WCF service doesn't contain any OperationContracts" + QF
    [ServiceContract]
    interface IService2
    {
        string GetData(int value);

    }

    // 20161RTM: Inspection "WCF OperationContract can be placed only inside a type marked as ServiceContract" + QF
    interface IService3
    {
        [OperationContract]
        string GetData(int value);

    }

    // 20161RTM: CA "Annotate public fields and properties with [DataMember]"
    [DataContract]
    public class CompositeType
    {
        public bool BoolValue { get; set; } = true;

        public string StringValue { get; set; } = "Hello ";

        public int IntValue { get; set; } = 12532;
    }


    // 20161RTM: CA "Annotate enum members with [EnumMember]"
    [SuppressMessage("ReSharper", "InconsistentNaming"), 
     SuppressMessage("ReSharper", "UnusedMember.Global")]
    [DataContract]
    enum MicrosoftAcronyms
    {
        ADONET,
        ASPNET,
        ASPNETMVC,
        CDONTS,
        CSPDK,
        DACL,
        DNA,
        UWP,
        WCF,
        WPF,
        WWF
    }
}
