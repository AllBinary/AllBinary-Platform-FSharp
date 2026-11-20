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
type GameInput =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable gameKeyEventList : BasicArrayList
    [<DefaultValue(false)>] val mutable removalGameKeyEventList : BasicArrayList
    [<DefaultValue(false)>] val mutable isRemoveDuplicateKeyPresses : bool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameInput.jclinitDone then
            GameInput.jclinitDone <- true
            GameInput.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_GameInput() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        ()
    
    new (gameKeyEventList: BasicArrayList, removalGameKeyEventList: BasicArrayList) as this =
        {  }
        then
            this.jfields_GameInput()
            this.jctor1(gameKeyEventList, removalGameKeyEventList)
    member this.jctor1(gameKeyEventList: BasicArrayList, removalGameKeyEventList: BasicArrayList) : unit =
        this.gameKeyEventList <- gameKeyEventList
        this.removalGameKeyEventList <- removalGameKeyEventList
        this.isRemoveDuplicateKeyPresses <- Features.getInstance().isFeature(InputFeatureFactory.getInstance().REMOVE_DUPLICATE_KEY_PRESSES)
        ()
    
    abstract add : gameKeyEvent: GameKeyEvent -> unit
    default this.add(gameKeyEvent: GameKeyEvent) : unit =
        let mutable jflow = 0
        if this.isRemoveDuplicateKeyPresses && this.gameKeyEventList.contains(gameKeyEvent) then
            jflow <- 1
        if jflow = 0 then
            if not (JR.same(gameKeyEvent, null)) then
                ignore (this.gameKeyEventList.add(gameKeyEvent))
            else
                this.logUtil.putF("Danger Passed Null GameKeyEvent", this, this.commonStrings.ADD)
    
    abstract addForRemoval : gameKeyEvent: GameKeyEvent -> unit
    default this.addForRemoval(gameKeyEvent: GameKeyEvent) : unit =
        ignore (this.removalGameKeyEventList.add(gameKeyEvent))
    
    abstract isForRemoval : gameKeyEvent: GameKeyEvent -> bool
    default this.isForRemoval(gameKeyEvent: GameKeyEvent) : bool =
        this.removalGameKeyEventList.contains(gameKeyEvent)
    
    abstract clear : unit -> unit
    default this.clear() : unit =
        this.gameKeyEventList.clear()
    
    abstract removeNonAIInputGameKeyEvents : unit -> unit
    default this.removeNonAIInputGameKeyEvents() : unit =
        let mutable list_ : BasicArrayList = this.gameKeyEventList
        let mutable gameKeyEvent : GameKeyEvent = null
        let mutable index : int = list_.size()
        while ((index <- index - 1; index)) >= 0 do
            gameKeyEvent <- (box (list_.objectArray.[index]) :?> GameKeyEvent)
            if gameKeyEvent.getSourceId() <> 1 then
                ignore (list_.removeAt(index))
    
    abstract update : unit -> unit
    default this.update() : unit =
        let mutable removeList : BasicArrayList = this.removalGameKeyEventList
        let mutable list_ : BasicArrayList = this.gameKeyEventList
        let mutable size : int = removeList.size()
        let mutable index : int = 0
        while index < size do
            let mutable anyType : obj = removeList.objectArray.[index]
            let mutable index2 : int = list_.size()
            while ((index2 <- index2 - 1; index2)) >= 0 do
                if (JR.same(list_.objectArray.[index2], anyType)) then
                    ignore (list_.removeAt(index2))
            index <- index + 1
        removeList.clear()
    
    abstract getRemovalGameKeyEventList : unit -> BasicArrayList
    default this.getRemovalGameKeyEventList() : BasicArrayList =
        this.removalGameKeyEventList
    
    abstract getGameKeyEventList : unit -> BasicArrayList
    default this.getGameKeyEventList() : BasicArrayList =
        this.gameKeyEventList


