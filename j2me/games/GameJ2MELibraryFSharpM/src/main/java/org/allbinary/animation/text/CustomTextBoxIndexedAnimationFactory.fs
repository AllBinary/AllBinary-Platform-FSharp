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
type CustomTextBoxIndexedAnimationFactory =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable scaleProperties : ScaleProperties
    [<DefaultValue(false)>] val mutable maxLength : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CustomTextBoxIndexedAnimationFactory.jclinitDone then
            CustomTextBoxIndexedAnimationFactory.jclinitDone <- true
            CustomTextBoxIndexedAnimationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_CustomTextBoxIndexedAnimationFactory() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    new (fontSize: int, maxLength: int) as this =
        {  }
        then
            this.jfields_CustomTextBoxIndexedAnimationFactory()
            this.jctor1(fontSize, maxLength)
    member this.jctor1(fontSize: int, maxLength: int) : unit =
        this.scaleProperties <- (new ScaleProperties())
        this.scaleProperties.scaleHeight <- fontSize
        this.maxLength <- maxLength
        ()
    
    abstract getInstance : instanceId: int -> Animation
    default this.getInstance(instanceId: int) : Animation =
        let mutable abToGBUtil : ABToGBUtil = ABToGBUtil.getInstance()
        let mutable abCanvas : AllBinaryGameCanvas = (box (abToGBUtil.abCanvas) :?> AllBinaryGameCanvas)
        let mutable font : Font = Font.getFont(Font.FACE_SYSTEM, Font.STYLE_PLAIN, this.scaleProperties.scaleHeight)
        let mutable customTextBox : CustomTextBox = (new CustomTextBox2(abCanvas.getCustomCommandListener(), StringUtil.getInstance().EMPTY_STRING, StringUtil.getInstance().EMPTY_STRING, this.maxLength, TextField.ANY, font, abCanvas.getLayerManager().getBackgroundBasicColor(), abCanvas.getLayerManager().getForegroundBasicColor()))
        (new CustomTextBoxIndexedAnimation(customTextBox))
    
    abstract setInitialScale : scaleProperties: ScaleProperties -> unit
    default this.setInitialScale(scaleProperties: ScaleProperties) : unit =
        let mutable fontSize : int = this.scaleProperties.scaleHeight
        this.scaleProperties <- scaleProperties
        if this.scaleProperties.scaleHeight < 6 then
            this.scaleProperties.scaleHeight <- fontSize
    interface AnimationInterfaceFactoryInterface with
        member this.getInstance(jp0: int) : Animation = this.getInstance(jp0)
        member this.setInitialScale(jp0: ScaleProperties) : unit = this.setInitialScale(jp0)
    interface BasicAnimationInterfaceFactoryInterface


