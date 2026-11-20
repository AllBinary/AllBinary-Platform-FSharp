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
type CustomTextBox =
    inherit GameCommandCanvas
    [<DefaultValue(false)>] val mutable textFieldItem : ABTextFieldItem
    [<DefaultValue(false)>] val mutable inputFactory : InputFactory
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CustomTextBox.jclinitDone then
            CustomTextBox.jclinitDone <- true
            CustomTextBox.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_CustomTextBox() : unit =
        this.inputFactory <- InputFactory.getInstance()
        ()
    
    new (cmdListener: CommandListener, label: string, text: string, maxSize: int, constraints: int, font: Font, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) as this =
        { inherit GameCommandCanvas(cmdListener, label, backgroundBasicColor, foregroundBasicColor) }
        then
            this.jfields_CustomTextBox()
            this.jctor1(cmdListener, label, text, maxSize, constraints, font, backgroundBasicColor, foregroundBasicColor)
    member this.jctor1(cmdListener: CommandListener, label: string, text: string, maxSize: int, constraints: int, font: Font, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) : unit =
        ()
        let mutable stringUtil : StringUtil = StringUtil.getInstance()
        let mutable textFieldItem : ABTextFieldItem = (new ABTextFieldItem(this, (new TextItemVisitor()), stringUtil.EMPTY_STRING, stringUtil.EMPTY_STRING, maxSize, 0, stringUtil.EMPTY_STRING, font, backgroundBasicColor, foregroundBasicColor))
        textFieldItem.setString(text)
        this.textFieldItem <- textFieldItem
        this.setTitle(label)
        ()
    
    abstract submit : unit -> unit
    default this.submit() : unit =
        ()
    
    abstract onEventRaw : keyCode: int * deviceId: int * repeated: bool -> unit
    default this.onEventRaw(keyCode: int, deviceId: int, repeated: bool) : unit =
        this.logUtil.putF((new StringMaker()).append(this.commonStrings.START).appendint(keyCode).ToString(), this, "onEvent")
        this.keyPressedByDevice(keyCode, deviceId)
    
    override this.keyPressed(keyCode: int) : unit =
        this.keyPressedByDevice(keyCode, 0)
    
    override this.keyReleased(keyCode: int) : unit =
        this.keyReleasedByDevice(keyCode, 0)
    
    override this.keyRepeated(keyCode: int) : unit =
        this.keyRepeatedByDevice(keyCode, 0)
    
    override this.keyPressedByDevice(keyCode: int, deviceId: int) : unit =
        try
            this.logUtil.putF((new StringMaker()).append(CommonSeps.getInstance().SPACE).appendint(keyCode).ToString(), this, this.gameInputStrings.KEY_PRESSED)
            let mutable platformKeyFactory : PlatformKeyFactory = PlatformKeyFactory.getInstance()
            let mutable input : Input = this.inputFactory.getInstanceById(keyCode)
            if platformKeyFactory.isSubmission(input) then
                this.submit()
            else
                this.textFieldItem.keyPressed(keyCode)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.gameInputStrings.KEY_PRESSED, e)
            | _ -> reraise ()
    
    override this.keyReleasedByDevice(keyCode: int, deviceId: int) : unit =
        ()
    
    override this.paint(graphics: Graphics) : unit =
        graphics.setColor(this.backgroundColor)
        graphics.fillRect(0, 0, this.displayInfo.getLastWidth(), this.displayInfo.getLastHeight())
        graphics.setColor(this.foregroundColor)
        if not (J2MEUtil.isJ2ME()) then
            graphics.drawString(this.getTitle(), 8, 1, 0)
        this.paintXY(graphics, 8, (graphics.getFont().getHeight() + 2))
        base.paint(graphics)
    
    abstract paintXY : graphics: Graphics * x: int * y: int -> unit
    default this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        this.textFieldItem.paintXY(graphics, x, y)
    
    abstract getTextFieldItem : unit -> ABTextFieldItem
    default this.getTextFieldItem() : ABTextFieldItem =
        this.textFieldItem
    interface RawKeyEventListener with
        member this.onEventRaw(jp0: int, jp1: int, jp2: bool) : unit = this.onEventRaw(jp0, jp1, jp2)


