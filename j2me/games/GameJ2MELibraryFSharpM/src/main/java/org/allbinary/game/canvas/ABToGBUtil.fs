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
type ABToGBUtil =
    [<DefaultValue(false)>] val mutable abCanvas : Canvas
    [<DefaultValue(false)>] val mutable allBinaryGameLayerManager : AllBinaryGameLayerManager
    [<DefaultValue(false)>] static val mutable private jcell_instance : ABToGBUtil
    static member instance with get() : ABToGBUtil = (ABToGBUtil.jclinit(); ABToGBUtil.jcell_instance) and set (jvalue: ABToGBUtil) = (ABToGBUtil.jclinit(); ABToGBUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ABToGBUtil.jclinitDone then
            ABToGBUtil.jclinitDone <- true
            ABToGBUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ABToGBUtil.jcell_instance <- (new ABToGBUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_ABToGBUtil()
    member this.jfields_ABToGBUtil() : unit =
        this.abCanvas <- NullCanvas.NULL_CANVAS
        this.allBinaryGameLayerManager <- AllBinaryGameLayerManager.getNullInstance()
        ()
    
    static member getInstance() : ABToGBUtil =
        ABToGBUtil.instance


