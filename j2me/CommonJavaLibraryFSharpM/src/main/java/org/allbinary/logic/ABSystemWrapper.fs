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
type ABSystemWrapper =
    [<DefaultValue(false)>] static val mutable private jcell_instance : ABSystemWrapper
    static member instance with get() : ABSystemWrapper = (ABSystemWrapper.jclinit(); ABSystemWrapper.jcell_instance) and set (jvalue: ABSystemWrapper) = (ABSystemWrapper.jclinit(); ABSystemWrapper.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ABSystemWrapper.jclinitDone then
            ABSystemWrapper.jclinitDone <- true
            ABSystemWrapper.jclinitBody()
    static member private jclinitBody() : unit =
        ABSystemWrapper.jcell_instance <- (new ABSystemWrapper())
        ()
    new () =
        {  }
    
    static member getInstance() : ABSystemWrapper =
        ABSystemWrapper.instance
    
    abstract arraycopy : src: obj * srcPos: int * dest: obj * destPos: int * length: int -> unit
    default this.arraycopy(src: obj, srcPos: int, dest: obj, destPos: int, length: int) : unit =
        JSystem.arraycopy(src, srcPos, dest, destPos, length)
    
    abstract currentTimeMillis : unit -> int64
    default this.currentTimeMillis() : int64 =
        JSystem.currentTimeMillis()


