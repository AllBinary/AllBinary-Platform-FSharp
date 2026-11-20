namespace rec AllBinary

// Generated Code Do Not Modify
(*
 *
 * AllBinary Open License Version 1
 * Copyright (c) 2011 AllBinary
 * 
 * By agreeing to this license you and any business entity you represent are
 * legally bound to the AllBinary Open License Version 1 legal agreement.
 * 
 * You may obtain the AllBinary Open License Version 1 legal agreement from
 * AllBinary or the root directory of AllBinary's AllBinary Platform repository.
 * 
 * Created By: Travis Berthelot
 *  
 *)

[<AllowNullLiteral>]
type StoreAppClientInformation =
    inherit AbeClientInformation
    [<DefaultValue(false)>] val mutable longArrayIdentifier : int64[]
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not StoreAppClientInformation.jclinitDone then
            StoreAppClientInformation.jclinitDone <- true
            StoreAppClientInformation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (name: string, version: string, specialName: string, shortName: string, longArrayIdentifier: int64[]) as this =
        { inherit AbeClientInformation(name, version, specialName, shortName) }
        then
            this.jctor1(name, version, specialName, shortName, longArrayIdentifier)
    member this.jctor1(name: string, version: string, specialName: string, shortName: string, longArrayIdentifier: int64[]) : unit =
        ()
        this.longArrayIdentifier <- longArrayIdentifier
        ()
    
    abstract getLongArrayIdentifier : unit -> int64[]
    default this.getLongArrayIdentifier() : int64[] =
        this.longArrayIdentifier
    interface LongArrayIdentifierInterface with
        member this.getLongArrayIdentifier() : int64[] = this.getLongArrayIdentifier()


