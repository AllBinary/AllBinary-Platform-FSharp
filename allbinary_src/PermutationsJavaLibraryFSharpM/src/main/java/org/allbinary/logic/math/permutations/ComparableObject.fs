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
type ComparableObject =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ComparableObject.jclinitDone then
            ComparableObject.jclinitDone <- true
            ComparableObject.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract compareTo : anyType: obj -> int
    default this.compareTo(anyType: obj) : int =
        let mutable jflow = 0
        let mutable jret : int = Unchecked.defaultof<int>
        if TsUtil.getInstance().hashCode(this) < TsUtil.getInstance().hashCode(anyType) then
            jret <- -1
            jflow <- 1
        elif TsUtil.getInstance().hashCode(this) > TsUtil.getInstance().hashCode(anyType) then
            jret <- 1
            jflow <- 1
        if jflow = 0 then
            jret <- 0
            jflow <- 1
        jret
    interface Comparable with
        member this.compareTo(jp0: obj) : int = this.compareTo(jp0)


