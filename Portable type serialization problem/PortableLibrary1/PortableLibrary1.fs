namespace PortableLibrary1
open System.Runtime.Serialization

[<DataContract>]
type Person = {
    [<field : DataMember>]
    FirstName:string
    [<field : DataMember>]
    LastName:string
}
