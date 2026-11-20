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
type GameFeatureChoiceGroups =
    [<DefaultValue(false)>] val mutable hashtable : ABHashtable
    [<DefaultValue(false)>] static val mutable private jcell_gameFeatureChoiceGroupsExclusive : GameFeatureChoiceGroups
    static member gameFeatureChoiceGroupsExclusive with get() : GameFeatureChoiceGroups = (GameFeatureChoiceGroups.jclinit(); GameFeatureChoiceGroups.jcell_gameFeatureChoiceGroupsExclusive) and set (jvalue: GameFeatureChoiceGroups) = (GameFeatureChoiceGroups.jclinit(); GameFeatureChoiceGroups.jcell_gameFeatureChoiceGroupsExclusive <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_gameFeatureChoiceGroupsMultiple : GameFeatureChoiceGroups
    static member gameFeatureChoiceGroupsMultiple with get() : GameFeatureChoiceGroups = (GameFeatureChoiceGroups.jclinit(); GameFeatureChoiceGroups.jcell_gameFeatureChoiceGroupsMultiple) and set (jvalue: GameFeatureChoiceGroups) = (GameFeatureChoiceGroups.jclinit(); GameFeatureChoiceGroups.jcell_gameFeatureChoiceGroupsMultiple <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameFeatureChoiceGroups.jclinitDone then
            GameFeatureChoiceGroups.jclinitDone <- true
            GameFeatureChoiceGroups.jclinitBody()
    static member private jclinitBody() : unit =
        GameFeatureChoiceGroups.jcell_gameFeatureChoiceGroupsExclusive <- (new GameFeatureChoiceGroups())
        GameFeatureChoiceGroups.jcell_gameFeatureChoiceGroupsMultiple <- (new GameFeatureChoiceGroups())
        ()
    member this.jfields_GameFeatureChoiceGroups() : unit =
        this.hashtable <- StdUtil.getInstance().createHashtable()
        ()
    
    new () as this =
        {  }
        then
            this.jfields_GameFeatureChoiceGroups()
    
    static member getExclusiveInstance() : GameFeatureChoiceGroups =
        GameFeatureChoiceGroups.gameFeatureChoiceGroupsExclusive
    
    static member getMultipleInstance() : GameFeatureChoiceGroups =
        GameFeatureChoiceGroups.gameFeatureChoiceGroupsMultiple
    
    abstract get : unit -> ABHashtable
    default this.get() : ABHashtable =
        this.hashtable
    
    abstract add : name: string * list_: BasicArrayList -> unit
    default this.add(name: string, list_: BasicArrayList) : unit =
        ignore (this.hashtable.put(name, list_))


