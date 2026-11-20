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
type CustomTextAnimation =
    inherit TextAnimation
    [<DefaultValue(false)>] val mutable fontDebugFactory : FontDebugFactory
    [<DefaultValue(false)>] val mutable fontSize : int
    [<DefaultValue(false)>] val mutable font : Font
    [<DefaultValue(false)>] val mutable lastText : string
    [<DefaultValue(false)>] val mutable hasChanged : bool
    [<DefaultValue(false)>] val mutable textWidth : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CustomTextAnimation.jclinitDone then
            CustomTextAnimation.jclinitDone <- true
            CustomTextAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_CustomTextAnimation() : unit =
        this.fontDebugFactory <- FontDebugFactory.getInstance()
        this.lastText <- StringUtil.getInstance().INIT_STRING
        this.hasChanged <- true
        ()
    
    new (text: string, fontSize: int, animationBehavior: AnimationBehavior) as this =
        { inherit TextAnimation(text, animationBehavior) }
        then
            this.jfields_CustomTextAnimation()
            this.jctor1(text, fontSize, animationBehavior)
    member this.jctor1(text: string, fontSize: int, animationBehavior: AnimationBehavior) : unit =
        ()
        this.fontSize <- fontSize
        this.font <- Font.getFont(Font.FACE_SYSTEM, Font.STYLE_PLAIN, fontSize)
        ()
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        this.myFontProcessor.process_(graphics)
        let mutable existingFont : Font = graphics.getFont()
        this.fontDebugFactory.setFont(this.font, graphics)
        base.paintXYNoUpdate(graphics, x, y)
        this.fontDebugFactory.setFont(existingFont, graphics)
    
    override this.setScale(scaleX: float32, scaleY: float32) : unit =
        if scaleX <> scaleY then
            raise ((new JRuntimeException()))
        this.hasChanged <- true
        this.font <- Font.getFont(Font.FACE_SYSTEM, Font.STYLE_PLAIN, JR.d2i(float ((float32 (this.fontSize) * scaleX))))
    
    override this.setTextWithOnMeasure(text: string, textChangeListener: TextChangeListener) : unit =
        base.setTextWithOnMeasure(text, textChangeListener)
    
    override this.setText(text: string) : unit =
        if not (JR.sameString(this.lastText, text)) then
            this.hasChanged <- true
            this.lastText <- text
            base.setText(text)
    
    abstract getText : unit -> string
    default this.getText() : string =
        this.lastText
    
    override this.getWidth() : int =
        if this.hasChanged then
            this.textWidth <- this.font.stringWidth(this.textArrayP.[0])
            this.hasChanged <- false
        this.textWidth
    
    override this.getFontHeight() : int =
        this.font.getHeight()
    interface TextInterface with
        member this.setTextWithOnMeasure(jp0: string, jp1: TextChangeListener) : unit = this.setTextWithOnMeasure(jp0, jp1)
        member this.getText() : string = this.getText()
        member this.setText(jp0: string) : unit = this.setText(jp0)
        member this.getFontHeight() : int = this.getFontHeight()
        member this.getWidth() : int = this.getWidth()


