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
type MultitouchReleaseHelper =
    inherit ReleaseHelper
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MultitouchReleaseHelper.jclinitDone then
            MultitouchReleaseHelper.jclinitDone <- true
            MultitouchReleaseHelper.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (touchButtonRecognizer: TouchButtonRecognizer) =
        { inherit ReleaseHelper(touchButtonRecognizer) }
    
    override this.release(touchButtonInput: TouchButtonInput, deviceId: int) : unit =
        let mutable cancelTouchButtonInput : TouchButtonInput = CancelTouchButtonInputFactory.getInstance().getCancel(touchButtonInput)
        let mutable nextTouchButtonInput : TouchButtonInput = null
        let mutable gameKeyEvent : GameKeyEvent = null
        let mutable index : int = this.touchButtonRecognizer.currentlyPressedTouchButtonSingleton.size() - 1
        while index >= 0 do
            nextTouchButtonInput <- this.touchButtonRecognizer.currentlyPressedTouchButtonSingleton.get(index)
            if (JR.same(cancelTouchButtonInput, nextTouchButtonInput)) then
                gameKeyEvent <- nextTouchButtonInput.getGameKeyEvent()
                this.touchButtonRecognizer.upGameKeyEventHandler.fireEvent(gameKeyEvent)
                this.touchButtonRecognizer.upGameKeyEventHandler.getInstanceForDevice(deviceId).fireEvent(gameKeyEvent)
                ignore (this.touchButtonRecognizer.currentlyPressedTouchButtonSingleton.removeAt(index))
            index <- index - 1


