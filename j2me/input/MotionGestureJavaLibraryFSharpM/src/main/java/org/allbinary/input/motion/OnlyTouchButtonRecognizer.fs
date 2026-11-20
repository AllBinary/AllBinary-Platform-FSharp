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
type OnlyTouchButtonRecognizer =
    inherit MotionRecognizer
    [<DefaultValue(false)>] val mutable touchButtonRecognizer : TouchButtonRecognizer
    [<DefaultValue(false)>] val mutable touchButtonProcessing : bool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OnlyTouchButtonRecognizer.jclinitDone then
            OnlyTouchButtonRecognizer.jclinitDone <- true
            OnlyTouchButtonRecognizer.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_OnlyTouchButtonRecognizer() : unit =
        this.touchButtonProcessing <- false
        ()
    
    new () as this =
        { inherit MotionRecognizer() }
        then
            this.jfields_OnlyTouchButtonRecognizer()
            this.jctor1()
    member this.jctor1() : unit =
        this.touchButtonRecognizer <- (new TouchButtonRecognizer())
        ()
    
    override this.processStartMotionEvent(x: int, y: int, deviceId: int, modifiers: int) : unit =
        if this.touchButtonRecognizer.pressTouchButtonInput(x, y, deviceId) then
            this.touchButtonProcessing <- true
    
    override this.processEndMotionEvent(x: int, y: int, deviceId: int, modifiers: int) : unit =
        let mutable jflow = 0
        if this.touchButtonProcessing then
            this.touchButtonProcessing <- false
        if this.touchButtonRecognizer.releaseTouchButtonInput(x, y, deviceId) then
            jflow <- 1
    
    override this.processDraggedMotionEvent(x: int, y: int, deviceId: int, modifiers: int) : unit =
        if this.touchButtonProcessing then
            ignore (this.touchButtonRecognizer.pressTouchButtonInput(x, y, deviceId))


