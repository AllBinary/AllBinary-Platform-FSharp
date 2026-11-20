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
type CommandTextItemArrayFactory =
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] val mutable visitorInterface : Visitor
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CommandTextItemArrayFactory.jclinitDone then
            CommandTextItemArrayFactory.jclinitDone <- true
            CommandTextItemArrayFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_CommandTextItemArrayFactory() : unit =
        this.list <- (new BasicArrayListD())
        ()
    
    new (visitorInterface: Visitor) as this =
        {  }
        then
            this.jfields_CommandTextItemArrayFactory()
            this.jctor1(visitorInterface)
    member this.jctor1(visitorInterface: Visitor) : unit =
        this.visitorInterface <- visitorInterface
        ()
    
    member this.getInstance(vector: obj, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) : ABCustomItem[] =
        let mutable vectorUtil : VectorUtil = VectorUtil.getInstance()
        let mutable size : int = vectorUtil.getSize(vector)
        this.list.clear()
        let mutable textItem : CommandTextItem = null
        let mutable priorityLimit : int = 7
        let mutable displayInfo : DisplayInfoSingleton = DisplayInfoSingleton.getInstance()
        let mutable isLargeEnoughDisplayForBigMenu : bool = (displayInfo.isPortrait() && (displayInfo.getLastHeight() >= ScreenInfo.getInstance().MEDIUM_WIDTH)) || ((not (displayInfo.isPortrait())) && (displayInfo.getLastWidth() >= ScreenInfo.getInstance().MEDIUM_WIDTH))
        if (not (isLargeEnoughDisplayForBigMenu)) && (size > 3) then
            priorityLimit <- 3
        let mutable command : Command = null
        let mutable index : int = 0
        while index < size do
            command <- (box (vectorUtil.elementAt(vector, index)) :?> Command)
            if command.getPriority() < priorityLimit then
                let mutable aBoolean : Boolean = (box (this.visitorInterface.visit(command)) :?> Boolean)
                if aBoolean.booleanValue() then
                    textItem <- (new CommandTextItem(command, LcduiImageItem.LAYOUT_DEFAULT, StringUtil.getInstance().EMPTY_STRING, backgroundBasicColor, foregroundBasicColor))
                    ignore (this.list.add(textItem))
            index <- index + 1
        let mutable textItemArray : ABCustomItem[] = (Array.zeroCreate<ABCustomItem> (this.list.size()))
        let mutable size2 : int = textItemArray.Length
        let mutable index : int = 0
        while index < size2 do
            textItemArray.[index] <- (box (this.list.objectArray.[index]) :?> ABCustomItem)
            index <- index + 1
        textItemArray


