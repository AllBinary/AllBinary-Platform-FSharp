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
type CustomTextBoxIndexedAnimation =
    inherit IndexedAnimation
    [<DefaultValue(false)>] val mutable customTextBox : CustomTextBox
    [<DefaultValue(false)>] val mutable lastText : string
    [<DefaultValue(false)>] val mutable hasChanged : bool
    [<DefaultValue(false)>] val mutable textChangeListener : TextChangeListener
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CustomTextBoxIndexedAnimation.jclinitDone then
            CustomTextBoxIndexedAnimation.jclinitDone <- true
            CustomTextBoxIndexedAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_CustomTextBoxIndexedAnimation() : unit =
        this.lastText <- StringUtil.getInstance().INIT_STRING
        this.hasChanged <- true
        this.textChangeListener <- TextChangeListener.getInstance()
        ()
    
    new (customTextBox: CustomTextBox) as this =
        { inherit IndexedAnimation(AnimationBehavior.getInstance()) }
        then
            this.jfields_CustomTextBoxIndexedAnimation()
            this.jctor1(customTextBox)
    member this.jctor1(customTextBox: CustomTextBox) : unit =
        ()
        this.customTextBox <- customTextBox
        ()
    
    override this.setBasicColorP(basicColor: BasicColor) : unit =
        this.customTextBox.getTextFieldItem().setForegroundBasicColorP(basicColor)
    
    override this.setBackgroundBasicColorP(basicColor: BasicColor) : unit =
        this.customTextBox.getTextFieldItem().setBackgroundBasicColorP(basicColor)
    
    abstract setTextWithOnMeasure : text: string * textChangeListener: TextChangeListener -> unit
    default this.setTextWithOnMeasure(text: string, textChangeListener: TextChangeListener) : unit =
        this.setText(text)
        this.textChangeListener <- textChangeListener
    
    abstract updateMeasurement : graphics: Graphics -> unit
    default this.updateMeasurement(graphics: Graphics) : unit =
        let mutable font : Font = graphics.getFont()
        this.textChangeListener.onMeasure()
        this.textChangeListener <- TextChangeListener.getInstance()
    
    abstract setText : text: string -> unit
    default this.setText(text: string) : unit =
        if not (JR.sameString(this.lastText, text)) then
            this.hasChanged <- true
            this.lastText <- text
            this.customTextBox.getTextFieldItem().setString(text)
    
    abstract getText : unit -> string
    default this.getText() : string =
        this.customTextBox.getTextFieldItem().getString()
    
    abstract onEventRaw : keyCode: int * deviceId: int * repeated: bool -> unit
    default this.onEventRaw(keyCode: int, deviceId: int, repeated: bool) : unit =
        this.customTextBox.onEventRaw(keyCode, deviceId, repeated)
    
    abstract getFontHeight : unit -> int
    default this.getFontHeight() : int =
        this.customTextBox.getTextFieldItem().getFontHeight()
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        this.customTextBox.paintXY(graphics, x, y)
    
    override this.paintThreedXYZ(graphics: Graphics, x: int, y: int, z: int) : unit =
        ()
    
    override this.getWidth() : int =
        base.getWidth()
    interface RawKeyEventListener with
        member this.onEventRaw(jp0: int, jp1: int, jp2: bool) : unit = this.onEventRaw(jp0, jp1, jp2)
    interface UpdateMyFontInterface with
        member this.updateMeasurement(jp0: Graphics) : unit = this.updateMeasurement(jp0)
    interface TextInterface with
        member this.setTextWithOnMeasure(jp0: string, jp1: TextChangeListener) : unit = this.setTextWithOnMeasure(jp0, jp1)
        member this.getText() : string = this.getText()
        member this.setText(jp0: string) : unit = this.setText(jp0)
        member this.getFontHeight() : int = this.getFontHeight()
        member this.getWidth() : int = this.getWidth()


