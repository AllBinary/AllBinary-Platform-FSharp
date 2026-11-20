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
type BasicBuildGameInitializerFactory =
    [<DefaultValue(false)>] static val mutable private jcell_NULL_BASE_BUILD_GMAE_INITIALIZER_FACTORY : BasicBuildGameInitializerFactory
    static member NULL_BASE_BUILD_GMAE_INITIALIZER_FACTORY with get() : BasicBuildGameInitializerFactory = (BasicBuildGameInitializerFactory.jclinit(); BasicBuildGameInitializerFactory.jcell_NULL_BASE_BUILD_GMAE_INITIALIZER_FACTORY) and set (jvalue: BasicBuildGameInitializerFactory) = (BasicBuildGameInitializerFactory.jclinit(); BasicBuildGameInitializerFactory.jcell_NULL_BASE_BUILD_GMAE_INITIALIZER_FACTORY <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicBuildGameInitializerFactory.jclinitDone then
            BasicBuildGameInitializerFactory.jclinitDone <- true
            BasicBuildGameInitializerFactory.jclinitBody()
    static member private jclinitBody() : unit =
        BasicBuildGameInitializerFactory.jcell_NULL_BASE_BUILD_GMAE_INITIALIZER_FACTORY <- (new BasicBuildGameInitializerFactory())
        ()
    new () =
        {  }
    
    abstract getInstance : unit -> GameInitializationInterface
    default this.getInstance() : GameInitializationInterface =
        BaseGameInitialization.NULL_BASE_GAME_INITIALIZATION
    interface GameInitializationInterfaceFactoryInterface with
        member this.getInstance() : GameInitializationInterface = this.getInstance()


