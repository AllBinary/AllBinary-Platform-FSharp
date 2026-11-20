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
type CurrentlyPressedTouchButtonSingletonDebug =
    inherit CurrentlyPressedTouchButtonSingleton
    [<DefaultValue(false)>] val mutable string : string
    [<DefaultValue(false)>] val mutable listString : string
    [<DefaultValue(false)>] val mutable appendText : string
    [<DefaultValue(false)>] val mutable PRESSED_AND_FIRED : string
    [<DefaultValue(false)>] val mutable PRESSED_AND_NOT_FIRED : string
    [<DefaultValue(false)>] val mutable ASSOCIATED_RELEASED_AND_FIRED : string
    [<DefaultValue(false)>] val mutable RELEASED_AND_FIRED : string
    [<DefaultValue(false)>] val mutable RELEASED_AND_FIRED_2 : string
    [<DefaultValue(false)>] val mutable RELEASED_AND_NOT_FIRED : string
    [<DefaultValue(false)>] static val mutable private jcell_instanceC : CurrentlyPressedTouchButtonSingletonDebug
    static member instanceC with get() : CurrentlyPressedTouchButtonSingletonDebug = (CurrentlyPressedTouchButtonSingletonDebug.jclinit(); CurrentlyPressedTouchButtonSingletonDebug.jcell_instanceC) and set (jvalue: CurrentlyPressedTouchButtonSingletonDebug) = (CurrentlyPressedTouchButtonSingletonDebug.jclinit(); CurrentlyPressedTouchButtonSingletonDebug.jcell_instanceC <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CurrentlyPressedTouchButtonSingletonDebug.jclinitDone then
            CurrentlyPressedTouchButtonSingletonDebug.jclinitDone <- true
            CurrentlyPressedTouchButtonSingletonDebug.jclinitBody()
    static member private jclinitBody() : unit =
        CurrentlyPressedTouchButtonSingletonDebug.jcell_instanceC <- (new CurrentlyPressedTouchButtonSingletonDebug())
        ()
    new () as this =
        { inherit CurrentlyPressedTouchButtonSingleton() }
        then
            this.jfields_CurrentlyPressedTouchButtonSingletonDebug()
    member this.jfields_CurrentlyPressedTouchButtonSingletonDebug() : unit =
        this.string <- StringUtil.getInstance().EMPTY_STRING
        this.listString <- StringUtil.getInstance().EMPTY_STRING
        this.appendText <- StringUtil.getInstance().EMPTY_STRING
        this.PRESSED_AND_FIRED <- "pressed & fired"
        this.PRESSED_AND_NOT_FIRED <- "pressed in button but not fired"
        this.ASSOCIATED_RELEASED_AND_FIRED <- "assoc. rel & fired"
        this.RELEASED_AND_FIRED <- "rel & fired 1"
        this.RELEASED_AND_FIRED_2 <- "rel & fired 2"
        this.RELEASED_AND_NOT_FIRED <- "rel & not fired"
        ()
    
    static member getInstance() : CurrentlyPressedTouchButtonSingleton =
        CurrentlyPressedTouchButtonSingletonDebug.instanceC
    
    member this.appendTouchButtonInput(append: string, touchButtonInput: TouchButtonInput) : unit =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append(touchButtonInput.ToString()))
        ignore (stringBuffer.append(CommonSeps.getInstance().SPACE))
        ignore (stringBuffer.append(append))
        this.appendText <- stringBuffer.ToString()
        this.string <- (new StringMaker()).append(this.listString).append(this.appendText).ToString()
    
    member this.append(append: string) : unit =
        this.appendText <- (new StringMaker()).append(this.appendText).append(append).ToString()
        this.string <- (new StringMaker()).append(this.listString).append(this.appendText).ToString()
    
    abstract clearLog : x: int * y: int -> unit
    default this.clearLog(x: int, y: int) : unit =
        this.appendText <- (new StringMaker()).append(GPoint.toStringStatic(x, y, 0)).append(CommonSeps.getInstance().SPACE).ToString()
        this.string <- (new StringMaker()).append(this.listString).append(this.appendText).ToString()
    
    abstract releaseAndNotFired : unit -> unit
    default this.releaseAndNotFired() : unit =
        this.append(this.RELEASED_AND_NOT_FIRED)
    
    abstract releaseAndFired : touchButtonInput: TouchButtonInput -> unit
    default this.releaseAndFired(touchButtonInput: TouchButtonInput) : unit =
        this.appendTouchButtonInput(this.RELEASED_AND_FIRED, touchButtonInput)
    
    abstract releaseAndFired2 : touchButtonInput: TouchButtonInput -> unit
    default this.releaseAndFired2(touchButtonInput: TouchButtonInput) : unit =
        this.appendTouchButtonInput(this.RELEASED_AND_FIRED_2, touchButtonInput)
    
    abstract releaseAndFiredAssociated : touchButtonInput: TouchButtonInput -> unit
    default this.releaseAndFiredAssociated(touchButtonInput: TouchButtonInput) : unit =
        this.appendTouchButtonInput(this.ASSOCIATED_RELEASED_AND_FIRED, touchButtonInput)
    
    abstract pressedAndFired : touchButtonInput: TouchButtonInput -> unit
    default this.pressedAndFired(touchButtonInput: TouchButtonInput) : unit =
        this.appendTouchButtonInput(this.PRESSED_AND_FIRED, touchButtonInput)
    
    abstract pressedAndNotFired : touchButtonInput: TouchButtonInput -> unit
    default this.pressedAndNotFired(touchButtonInput: TouchButtonInput) : unit =
        this.appendTouchButtonInput(this.PRESSED_AND_NOT_FIRED, touchButtonInput)
    
    override this.removeAt(index: int) : TouchButtonInput =
        let mutable touchButtonInput : TouchButtonInput = base.removeAt(index)
        this.listString <- this.list.ToString()
        this.string <- (new StringMaker()).append(this.listString).append(this.appendText).ToString()
        touchButtonInput
    
    override this.remove(touchButtonInput: TouchButtonInput) : bool =
        let mutable isRemoved : bool = base.remove(touchButtonInput)
        this.listString <- this.list.ToString()
        this.string <- (new StringMaker()).append(this.listString).append(this.appendText).ToString()
        isRemoved
    
    override this.add(touchButtonInput: TouchButtonInput) : unit =
        base.add(touchButtonInput)
        this.listString <- this.list.ToString()
        this.string <- (new StringMaker()).append(this.listString).append(this.appendText).ToString()
    
    override this.ToString() : string =
        this.string


