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
type AllBinaryGameLayerManager =
    inherit AllBinaryLayerManager
    [<DefaultValue(false)>] val mutable backgroundBasicColor : BasicColor
    [<DefaultValue(false)>] val mutable foregroundBasicColor : BasicColor
    [<DefaultValue(false)>] val mutable gameInfo : GameInfo
    [<DefaultValue(false)>] val mutable playerGameInputCompositeInterface : PlayerGameInputCompositeInterface
    [<DefaultValue(false)>] static val mutable private jcell_NULL_ALLBINARY_LAYER_MANAGER : obj
    static member NULL_ALLBINARY_LAYER_MANAGER with get() : obj = (AllBinaryGameLayerManager.jclinit(); AllBinaryGameLayerManager.jcell_NULL_ALLBINARY_LAYER_MANAGER) and set (jvalue: obj) = (AllBinaryGameLayerManager.jclinit(); AllBinaryGameLayerManager.jcell_NULL_ALLBINARY_LAYER_MANAGER <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_ID : Integer
    static member ID with get() : Integer = (AllBinaryGameLayerManager.jclinit(); AllBinaryGameLayerManager.jcell_ID) and set (jvalue: Integer) = (AllBinaryGameLayerManager.jclinit(); AllBinaryGameLayerManager.jcell_ID <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AllBinaryGameLayerManager.jclinitDone then
            AllBinaryGameLayerManager.jclinitDone <- true
            AllBinaryGameLayerManager.jclinitBody()
    static member private jclinitBody() : unit =
        AllBinaryGameLayerManager.jcell_NULL_ALLBINARY_LAYER_MANAGER <- NullUtil.getInstance().NULL_OBJECT
        AllBinaryGameLayerManager.jcell_ID <- SmallIntegerSingletonFactory.getInstance().getAt(22)
        ()
    member this.jfields_AllBinaryGameLayerManager() : unit =
        this.playerGameInputCompositeInterface <- NullPlayerGameInputComposite.NULL_PLAYER_GAME_INPUT_COMPOSITE
        ()
    
    static member getNullInstance() : AllBinaryGameLayerManager =
        if (JR.same(AllBinaryGameLayerManager.NULL_ALLBINARY_LAYER_MANAGER, NullUtil.getInstance().NULL_OBJECT)) then
            AllBinaryGameLayerManager.NULL_ALLBINARY_LAYER_MANAGER <- (new AllBinaryGameLayerManager(BasicColorFactory.getInstance().BLACK, BasicColorFactory.getInstance().WHITE, GameInfo.NONE))
        (box (AllBinaryGameLayerManager.NULL_ALLBINARY_LAYER_MANAGER) :?> AllBinaryGameLayerManager)
    
    new (backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor, gameInfo: GameInfo) as this =
        { inherit AllBinaryLayerManager() }
        then
            this.jfields_AllBinaryGameLayerManager()
            this.jctor1(backgroundBasicColor, foregroundBasicColor, gameInfo)
    member this.jctor1(backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor, gameInfo: GameInfo) : unit =
        this.backgroundBasicColor <- backgroundBasicColor
        this.foregroundBasicColor <- foregroundBasicColor
        let mutable itemColorFactory : ItemColorFactory = ItemColorFactory.getInstance()
        itemColorFactory.INVERT_PAINT <- this.backgroundBasicColor.intValue()
        itemColorFactory.PAINT <- this.foregroundBasicColor.intValue()
        this.gameInfo <- gameInfo
        ()
    
    abstract getLayerManager : unit -> AllBinaryLayerManager
    default this.getLayerManager() : AllBinaryLayerManager =
        this
    
    abstract init : unit -> unit
    default this.init() : unit =
        ()
    
    abstract getBackgroundBasicColor : unit -> BasicColor
    default this.getBackgroundBasicColor() : BasicColor =
        this.backgroundBasicColor
    
    abstract setBackgroundBasicColor : backgroundBasicColor: BasicColor -> unit
    default this.setBackgroundBasicColor(backgroundBasicColor: BasicColor) : unit =
        this.backgroundBasicColor <- backgroundBasicColor
        ItemColorFactory.getInstance().INVERT_PAINT <- this.backgroundBasicColor.intValue()
    
    abstract getForegroundBasicColor : unit -> BasicColor
    default this.getForegroundBasicColor() : BasicColor =
        this.foregroundBasicColor
    
    abstract setForegroundBasicColor : foregroundBasicColor: BasicColor -> unit
    default this.setForegroundBasicColor(foregroundBasicColor: BasicColor) : unit =
        this.foregroundBasicColor <- foregroundBasicColor
        ItemColorFactory.getInstance().PAINT <- this.foregroundBasicColor.intValue()
    
    abstract getGameInfo : unit -> GameInfo
    default this.getGameInfo() : GameInfo =
        this.gameInfo
    
    abstract setGameInfo : gameInfo: GameInfo -> unit
    default this.setGameInfo(gameInfo: GameInfo) : unit =
        this.gameInfo <- gameInfo
    
    abstract setLayerProcessorList : list_: BasicArrayList -> unit
    default this.setLayerProcessorList(list_: BasicArrayList) : unit =
        let mutable layerProcessorInterfaceArray : LayerProcessor[] = (Array.zeroCreate<LayerProcessor> (list_.size()))
        let mutable size : int = layerProcessorInterfaceArray.Length
        let mutable index : int = 0
        while index < size do
            layerProcessorInterfaceArray.[index] <- (box (list_.objectArray.[index]) :?> LayerProcessor)
            index <- index + 1
        this.setLayerProcessorArray(layerProcessorInterfaceArray)
    
    abstract setPlayerGameInputCompositeInterface : playerGameInputCompositeInterface: PlayerGameInputCompositeInterface -> unit
    default this.setPlayerGameInputCompositeInterface(playerGameInputCompositeInterface: PlayerGameInputCompositeInterface) : unit =
        this.playerGameInputCompositeInterface <- playerGameInputCompositeInterface
    
    abstract getPlayerGameInputCompositeInterface : unit -> PlayerGameInputCompositeInterface
    default this.getPlayerGameInputCompositeInterface() : PlayerGameInputCompositeInterface =
        this.playerGameInputCompositeInterface


