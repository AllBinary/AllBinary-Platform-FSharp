namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2026 AllBinary 
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
type ProgressEndListener =
    [<DefaultValue(false)>] static val mutable private jcell_instance : ProgressEndListener
    static member instance with get() : ProgressEndListener = (ProgressEndListener.jclinit(); ProgressEndListener.jcell_instance) and set (jvalue: ProgressEndListener) = (ProgressEndListener.jclinit(); ProgressEndListener.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ProgressEndListener.jclinitDone then
            ProgressEndListener.jclinitDone <- true
            ProgressEndListener.jclinitBody()
    static member private jclinitBody() : unit =
        ProgressEndListener.jcell_instance <- (new ProgressEndListener())
        ()
    new () =
        {  }
    
    abstract onEndEvent : unit -> unit
    default this.onEndEvent() : unit =
        ()


