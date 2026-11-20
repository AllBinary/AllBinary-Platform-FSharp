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
type EnumerationUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : EnumerationUtil
    static member instance with get() : EnumerationUtil = (EnumerationUtil.jclinit(); EnumerationUtil.jcell_instance) and set (jvalue: EnumerationUtil) = (EnumerationUtil.jclinit(); EnumerationUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not EnumerationUtil.jclinitDone then
            EnumerationUtil.jclinitDone <- true
            EnumerationUtil.jclinitBody()
    static member private jclinitBody() : unit =
        EnumerationUtil.jcell_instance <- (new EnumerationUtil())
        ()
    new () =
        {  }
    
    static member getInstance() : EnumerationUtil =
        EnumerationUtil.instance
    
    abstract hasMoreElements : enumeration: Enumeration -> bool
    default this.hasMoreElements(enumeration: Enumeration) : bool =
        enumeration.hasMoreElements()
    
    abstract nextElement : enumeration: Enumeration -> obj
    default this.nextElement(enumeration: Enumeration) : obj =
        enumeration.nextElement()
    
    abstract getAsArray : enumeration: Enumeration -> obj[]
    default this.getAsArray(enumeration: Enumeration) : obj[] =
        let mutable basicArrayList : BasicArrayList = (new BasicArrayListD())
        while this.hasMoreElements(enumeration) do
            ignore (basicArrayList.add(this.nextElement(enumeration)))
        basicArrayList.toArray()


