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
type NullUtil =
    [<DefaultValue(false)>] val mutable NULL_OBJECT : obj
    [<DefaultValue(false)>] val mutable NULL_CLASS : string
    [<DefaultValue(false)>] val mutable NULL_OBJECT_ARRAY : obj[]
    [<DefaultValue(false)>] val mutable NULL_CHAR_ARRAY : char[]
    [<DefaultValue(false)>] val mutable NULL_BYTE_ARRAY : sbyte[]
    [<DefaultValue(false)>] val mutable NULL_SHORT_ARRAY_ARRAY : int16[][]
    [<DefaultValue(false)>] val mutable NULL_INT_ARRAY : int[]
    [<DefaultValue(false)>] val mutable NULL_INT_ARRAY_ARRAY : int[][]
    [<DefaultValue(false)>] val mutable NULL_INT_ARRAY_ARRAY_ARRAY : int[][][]
    [<DefaultValue(false)>] val mutable NULL_FLOAT_ARRAY : float32[]
    [<DefaultValue(false)>] static val mutable private jcell_instance : NullUtil
    static member instance with get() : NullUtil = (NullUtil.jclinit(); NullUtil.jcell_instance) and set (jvalue: NullUtil) = (NullUtil.jclinit(); NullUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullUtil.jclinitDone then
            NullUtil.jclinitDone <- true
            NullUtil.jclinitBody()
    static member private jclinitBody() : unit =
        NullUtil.jcell_instance <- (new NullUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_NullUtil()
    member this.jfields_NullUtil() : unit =
        this.NULL_OBJECT <- (new obj())
        this.NULL_CLASS <- JR.getClass(this.NULL_OBJECT)
        this.NULL_OBJECT_ARRAY <- (Array.zeroCreate<obj> (0))
        this.NULL_CHAR_ARRAY <- (Array.zeroCreate<char> (0))
        this.NULL_BYTE_ARRAY <- (Array.zeroCreate<sbyte> (0))
        this.NULL_SHORT_ARRAY_ARRAY <- (JR.newArray2<int16>(0, 0))
        this.NULL_INT_ARRAY <- (Array.zeroCreate<int> (0))
        this.NULL_INT_ARRAY_ARRAY <- (JR.newArray2<int>(0, 0))
        this.NULL_INT_ARRAY_ARRAY_ARRAY <- (JR.newArray3<int>(0, 0, 0))
        this.NULL_FLOAT_ARRAY <- (Array.zeroCreate<float32> (0))
        ()
    
    static member getInstance() : NullUtil =
        NullUtil.instance


