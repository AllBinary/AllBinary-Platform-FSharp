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
type CommonGameInitialization =
    inherit BaseGameInitialization
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CommonGameInitialization.jclinitDone then
            CommonGameInitialization.jclinitDone <- true
            CommonGameInitialization.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_CommonGameInitialization() : unit =
        this.commonStrings <- CommonStrings.getInstance()
        ()
    
    new (resourceInitializationArray: ResourceInitialization[], portion: int) as this =
        { inherit BaseGameInitialization(resourceInitializationArray, portion) }
        then
            this.jfields_CommonGameInitialization()
    
    override this.init(abeClientInformation: AbeClientInformationInterface, commandListener: CommandListener, level: int) : unit =
        base.init(abeClientInformation, commandListener, level)
        let mutable resourceLoadingLevelFactory : ResourceLoadingLevelFactory = ResourceLoadingLevelFactory.getInstance()
        if (not (this.isGameInitialized())) && (level = resourceLoadingLevelFactory.LOAD_ALL.getLevel()) then
            this.setGameInitialized(true)
            let mutable progressCanvas : ProgressCanvas = ProgressCanvasFactory.getInstance()
            SmallIntegerSingletonFactory.getInstance().init()
            progressCanvas.addNormalPortion(50, "Integers")
            PointFactory.getInstance().init()
            progressCanvas.addNormalPortion(50, "Points")
            ignore (AngleFactory.getInstance())
            progressCanvas.addNormalPortion(50, "Angles")
            this.initGame()
            this.resourceInitializationArray.[this.GAME_RESOURCES].init()
        base.resourceInitialization(level)
    
    abstract initGame : unit -> unit
    default this.initGame() : unit =
        raise ((new JException(this.commonStrings.NOT_IMPLEMENTED)))


