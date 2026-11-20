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
type BasicArrayListS =
    inherit BasicArrayList
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicArrayListS.jclinitDone then
            BasicArrayListS.jclinitDone <- true
            BasicArrayListS.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (size: int) as this =
        { inherit BasicArrayList(NullUtil.getInstance().NULL_OBJECT_ARRAY) }
        then
            this.jctor1(size)
    member this.jctor1(size: int) : unit =
        ()
        if size < 0 then
            raise ((new JIllegalArgumentException((new StringMaker()).append("Init Size Exception: ").appendint(size).ToString())))
        this.objectArray <- (Array.zeroCreate<obj> (size))
        ()


