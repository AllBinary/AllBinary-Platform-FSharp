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
type CustomTextAnimationFactory =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable animationBehaviorFactory : AnimationBehaviorFactory
    [<DefaultValue(false)>] val mutable basicColor : BasicColor
    [<DefaultValue(false)>] val mutable text : string
    [<DefaultValue(false)>] val mutable initScaleHeight : int
    [<DefaultValue(false)>] val mutable dx : int
    [<DefaultValue(false)>] val mutable dy : int
    [<DefaultValue(false)>] val mutable font : Font
    [<DefaultValue(false)>] val mutable scaleProperties : ScaleProperties
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CustomTextAnimationFactory.jclinitDone then
            CustomTextAnimationFactory.jclinitDone <- true
            CustomTextAnimationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_CustomTextAnimationFactory() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.basicColor <- BasicColorFactory.getInstance().BLACK
        this.dx <- 0
        this.dy <- 0
        ()
    
    static member createDXY(text: string, fontSize: int, dx: int, dy: int, animationBehaviorFactory: AnimationBehaviorFactory) : CustomTextAnimationFactory =
        let mutable customTextAnimationFactory : CustomTextAnimationFactory = (new CustomTextAnimationFactory(text, fontSize, animationBehaviorFactory))
        customTextAnimationFactory.dx <- dx
        customTextAnimationFactory.dy <- dy
        customTextAnimationFactory
    
    new (text: string, fontSize: int, animationBehaviorFactory: AnimationBehaviorFactory) as this =
        {  }
        then
            this.jfields_CustomTextAnimationFactory()
            this.jctor1(text, fontSize, animationBehaviorFactory)
    member this.jctor1(text: string, fontSize: int, animationBehaviorFactory: AnimationBehaviorFactory) : unit =
        this.scaleProperties <- (new ScaleProperties())
        this.text <- text
        this.scaleProperties.scaleHeight <- fontSize - (fontSize / 4)
        this.initScaleHeight <- this.scaleProperties.scaleHeight
        this.animationBehaviorFactory <- animationBehaviorFactory
        this.font <- Font.getFont(Font.FACE_SYSTEM, Font.STYLE_PLAIN, this.initScaleHeight)
        ()
    
    abstract getInstance : instanceId: int -> Animation
    default this.getInstance(instanceId: int) : Animation =
        let mutable customTextAnimation : CustomTextAnimation = null
        if (this.dx <> 0) || (this.dy <> 0) then
            customTextAnimation <- (new AdjustCustomTextAnimation(this.text, this.scaleProperties.scaleHeight, this.dx, this.dy, this.animationBehaviorFactory.getOrCreateInstance()))
        else
            customTextAnimation <- (new CustomTextAnimation(this.text, this.scaleProperties.scaleHeight, this.animationBehaviorFactory.getOrCreateInstance()))
        customTextAnimation.setBasicColorP(this.basicColor)
        customTextAnimation
    
    abstract setInitialScale : scaleProperties: ScaleProperties -> unit
    default this.setInitialScale(scaleProperties: ScaleProperties) : unit =
        ()
    
    abstract getWidth : unit -> int
    default this.getWidth() : int =
        this.font.stringWidth(this.text)
    
    abstract getHeight : unit -> int
    default this.getHeight() : int =
        this.font.getHeight()
    interface AnimationInterfaceFactoryInterface with
        member this.getInstance(jp0: int) : Animation = this.getInstance(jp0)
        member this.setInitialScale(jp0: ScaleProperties) : unit = this.setInitialScale(jp0)
    interface BasicAnimationInterfaceFactoryInterface


