namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type GLHolder =
    [<DefaultValue(false)>] val mutable isCreated : bool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GLHolder.jclinitDone then
            GLHolder.jclinitDone <- true
            GLHolder.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_GLHolder() : unit =
        this.isCreated <- true
        ()
    
    new () as this =
        {  }
        then
            this.jfields_GLHolder()
    
    abstract runOnSurfaceCreated : renderer: obj -> unit
    default this.runOnSurfaceCreated(renderer: obj) : unit =
        ()
    
    abstract runOnSurfaceChanged : renderer: obj * width: int * height: int -> unit
    default this.runOnSurfaceChanged(renderer: obj, width: int, height: int) : unit =
        ()
    
    abstract run : renderer: obj -> unit
    default this.run(renderer: obj) : unit =
        ()


