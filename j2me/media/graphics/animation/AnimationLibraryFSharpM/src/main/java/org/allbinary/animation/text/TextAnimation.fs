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
type TextAnimation =
    inherit IndexedAnimation
    [<DefaultValue(false)>] val mutable updateMyFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable myFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable textArrayP : string[]
    [<DefaultValue(false)>] val mutable anchor : int
    [<DefaultValue(false)>] val mutable fontHeight : int
    [<DefaultValue(false)>] val mutable offsetY : int
    [<DefaultValue(false)>] val mutable textChangeListener : TextChangeListener
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TextAnimation.jclinitDone then
            TextAnimation.jclinitDone <- true
            TextAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_TextAnimation() : unit =
        this.updateMyFontProcessor <- (new UpdateMyFontProcessor(this))
        this.myFontProcessor <- this.updateMyFontProcessor
        this.textArrayP <- StringUtil.getInstance().ONE_EMPTY_STRING_ARRAY
        this.anchor <- Anchor.TOP_LEFT
        this.fontHeight <- 0
        this.offsetY <- 0
        this.textChangeListener <- TextChangeListener.getInstance()
        ()
    
    new (text: string, animationBehavior: AnimationBehavior) as this =
        { inherit IndexedAnimation(animationBehavior) }
        then
            this.jfields_TextAnimation()
            this.jctor1(text, animationBehavior)
    member this.jctor1(text: string, animationBehavior: AnimationBehavior) : unit =
        ()
        this.setText(text)
        ()
    
    abstract updateMeasurement : graphics: Graphics -> unit
    default this.updateMeasurement(graphics: Graphics) : unit =
        let mutable font : Font = graphics.getFont()
        this.fontHeight <- font.getHeight()
        let mutable adjustedFontHeight : int = JR.d2i(float (-((float (this.fontHeight) * 2.00))))
        this.offsetY <- (if SWTJOGLProcessor.getInstance().isJOGL() then adjustedFontHeight else 0)
        this.textChangeListener.onMeasure()
        this.textChangeListener <- TextChangeListener.getInstance()
        this.myFontProcessor <- MyFontProcessor.getInstance()
    
    override this.nextFrame() : unit =
        ()
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        this.myFontProcessor.process_(graphics)
        this.paintXYNoUpdate(graphics, x, y)
    
    abstract paintXYNoUpdate : graphics: Graphics * x: int * y: int -> unit
    default this.paintXYNoUpdate(graphics: Graphics, x: int, y: int) : unit =
        this.basicSetColorUtil.setBasicColorP3(graphics, this.getBasicColorP(), this.getColor())
        let mutable size : int = this.textArrayP.Length
        let mutable index : int = 0
        while index < size do
            graphics.drawString(this.textArrayP.[index], x, ((y + this.offsetY) + (index * this.fontHeight)), this.anchor)
            index <- index + 1
    
    abstract setTextWithOnMeasure : text: string * textChangeListener: TextChangeListener -> unit
    default this.setTextWithOnMeasure(text: string, textChangeListener: TextChangeListener) : unit =
        this.setText(text)
        this.textChangeListener <- textChangeListener
    
    abstract setText : text: string -> unit
    default this.setText(text: string) : unit =
        let mutable jflow = 0
        let mutable list_ : BasicArrayList = (new BasicArrayListD())
        if JString.length(text) > 0 then
            let mutable index : int = 0
            let mutable startIndex : int = 0
            let mutable endIndex : int = 0
            while jflow = 0 && (index >= 0) do
                startIndex <- index
                index <- JString.indexOf(text, '\n', startIndex)
                endIndex <- index
                if index < 0 then
                    endIndex <- JString.length(text)
                ignore (list_.add(JString.substring(text, startIndex, endIndex)))
                if index < 0 then
                    jflow <- 100002
                if jflow = 0 then
                    index <- index + 1
                if jflow = 200002 then jflow <- 0
            if jflow = 100002 then jflow <- 0
        if jflow = 0 then
            if list_.size() > 0 then
                let mutable textArray : string[] = (Array.zeroCreate<string> (list_.size()))
                let mutable size : int = list_.size()
                let mutable index : int = 0
                while index < size do
                    textArray.[index] <- (box (list_.get(index)) :?> string)
                    index <- index + 1
                this.textArrayP <- textArray
            else
                this.textArrayP <- StringUtil.getInstance().ONE_EMPTY_STRING_ARRAY
            this.myFontProcessor <- this.updateMyFontProcessor
    
    abstract getTextArray : unit -> string[]
    default this.getTextArray() : string[] =
        this.textArrayP
    
    abstract getFontHeight : unit -> int
    default this.getFontHeight() : int =
        this.fontHeight
    interface UpdateMyFontInterface with
        member this.updateMeasurement(jp0: Graphics) : unit = this.updateMeasurement(jp0)


