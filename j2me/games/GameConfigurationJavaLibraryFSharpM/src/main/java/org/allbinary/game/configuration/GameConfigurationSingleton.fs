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
type GameConfigurationSingleton =
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] val mutable hashtable : ABHashtable
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : GameConfigurationSingleton
    static member SINGLETON with get() : GameConfigurationSingleton = (GameConfigurationSingleton.jclinit(); GameConfigurationSingleton.jcell_SINGLETON) and set (jvalue: GameConfigurationSingleton) = (GameConfigurationSingleton.jclinit(); GameConfigurationSingleton.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameConfigurationSingleton.jclinitDone then
            GameConfigurationSingleton.jclinitDone <- true
            GameConfigurationSingleton.jclinitBody()
    static member private jclinitBody() : unit =
        GameConfigurationSingleton.jcell_SINGLETON <- (new GameConfigurationSingleton())
        ()
    
    static member getInstance() : GameConfigurationSingleton =
        GameConfigurationSingleton.SINGLETON
    
    new () as this =
        {  }
        then
            this.jctor1()
    member this.jctor1() : unit =
        this.list <- (new BasicArrayListD())
        this.hashtable <- StdUtil.getInstance().createHashtable()
        ()
    
    abstract getInstanceByName : name: string -> GameConfiguration
    default this.getInstanceByName(name: string) : GameConfiguration =
        (box (this.hashtable.get(name)) :?> GameConfiguration)
    
    abstract getOptionsBasicArrayList : unit -> BasicArrayList
    default this.getOptionsBasicArrayList() : BasicArrayList =
        this.list
    
    abstract add : gameConfiguration: GameConfiguration -> unit
    default this.add(gameConfiguration: GameConfiguration) : unit =
        ignore (this.list.add(gameConfiguration))
    
    abstract getHashtable : unit -> ABHashtable
    default this.getHashtable() : ABHashtable =
        this.hashtable


