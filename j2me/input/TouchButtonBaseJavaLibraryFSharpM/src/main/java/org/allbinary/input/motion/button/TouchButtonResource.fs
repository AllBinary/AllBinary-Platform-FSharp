namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * To change this license header, choose License Headers in Project Properties. 
 * To change this template file, choose Tools | Templates 
 * and open the template in the editor.  
 *)

[<AllowNullLiteral>]
type TouchButtonResource =
    [<DefaultValue(false)>] val mutable RESOURCE : string
    [<DefaultValue(false)>] val mutable HINT : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TouchButtonResource.jclinitDone then
            TouchButtonResource.jclinitDone <- true
            TouchButtonResource.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (resource: string, hint: string) as this =
        {  }
        then
            this.jctor1(resource, hint)
    member this.jctor1(resource: string, hint: string) : unit =
        this.RESOURCE <- resource
        this.HINT <- hint
        ()


