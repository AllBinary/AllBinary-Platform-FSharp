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
type UpdateMyFontProperties =
    [<DefaultValue(false)>] val mutable actionStringArray : string[]
    [<DefaultValue(false)>] val mutable keymappingBeginWidthArray : int[]
    [<DefaultValue(false)>] val mutable actionStringDeltaXArray : int[]
    [<DefaultValue(false)>] val mutable inputDeltaXArray : int[][]
    [<DefaultValue(false)>] val mutable sepArray : string[][]
    [<DefaultValue(false)>] val mutable sepWidthArray : int[][]
    [<DefaultValue(false)>] val mutable charHeight : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not UpdateMyFontProperties.jclinitDone then
            UpdateMyFontProperties.jclinitDone <- true
            UpdateMyFontProperties.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        {  }
        then
            this.jfields_UpdateMyFontProperties()
    member this.jfields_UpdateMyFontProperties() : unit =
        this.actionStringArray <- StringUtil.getInstance().getArrayInstance()
        this.keymappingBeginWidthArray <- NullUtil.getInstance().NULL_INT_ARRAY
        this.actionStringDeltaXArray <- NullUtil.getInstance().NULL_INT_ARRAY
        this.inputDeltaXArray <- NullUtil.getInstance().NULL_INT_ARRAY_ARRAY
        this.sepArray <- StringUtil.getInstance().ONE_EMPTY_STRING_ARRAY_OF_ARRAYS
        this.sepWidthArray <- NullUtil.getInstance().NULL_INT_ARRAY_ARRAY
        ()


