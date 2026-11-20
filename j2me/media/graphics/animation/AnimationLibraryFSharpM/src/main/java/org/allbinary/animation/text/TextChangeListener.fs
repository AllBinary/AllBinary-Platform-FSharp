namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type TextChangeListener =
    [<DefaultValue(false)>] static val mutable private jcell_instance : TextChangeListener
    static member instance with get() : TextChangeListener = (TextChangeListener.jclinit(); TextChangeListener.jcell_instance) and set (jvalue: TextChangeListener) = (TextChangeListener.jclinit(); TextChangeListener.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TextChangeListener.jclinitDone then
            TextChangeListener.jclinitDone <- true
            TextChangeListener.jclinitBody()
    static member private jclinitBody() : unit =
        TextChangeListener.jcell_instance <- (new TextChangeListener())
        ()
    new () =
        {  }
    
    static member getInstance() : TextChangeListener =
        TextChangeListener.instance
    
    abstract onMeasure : unit -> unit
    default this.onMeasure() : unit =
        ()


