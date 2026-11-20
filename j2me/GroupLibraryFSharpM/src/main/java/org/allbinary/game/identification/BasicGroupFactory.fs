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
type BasicGroupFactory =
    [<DefaultValue(false)>] val mutable NAME : string
    [<DefaultValue(false)>] val mutable NO_SUCH_GROUP : string
    [<DefaultValue(false)>] val mutable GOOD : Group
    [<DefaultValue(false)>] val mutable ENEMY : Group
    [<DefaultValue(false)>] val mutable ENEMY_ON_LEVEL : Group
    [<DefaultValue(false)>] val mutable NONE : Group
    [<DefaultValue(false)>] val mutable GOOD_ARRAY : Group[]
    [<DefaultValue(false)>] val mutable ENEMY_ARRAY : Group[]
    [<DefaultValue(false)>] val mutable ENEMY_ON_LEVEL_ARRAY : Group[]
    [<DefaultValue(false)>] val mutable NONE_ARRAY : Group[]
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (BasicGroupFactory.jclinit(); BasicGroupFactory.jcell_instance) and set (jvalue: obj) = (BasicGroupFactory.jclinit(); BasicGroupFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicGroupFactory.jclinitDone then
            BasicGroupFactory.jclinitDone <- true
            BasicGroupFactory.jclinitBody()
    static member private jclinitBody() : unit =
        BasicGroupFactory.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    new () as this =
        {  }
        then
            this.jfields_BasicGroupFactory()
    member this.jfields_BasicGroupFactory() : unit =
        this.NAME <- "GROUP_NAME"
        this.NO_SUCH_GROUP <- "No Such Group: "
        this.GOOD <- (new Group("Good Guys", int16 (0)))
        this.ENEMY <- (new Group("Bad Guys", int16 (1)))
        this.ENEMY_ON_LEVEL <- (new Group("Bad Guys on Level", int16 (2)))
        this.NONE <- (new Group("Not On A Team", int16 (3)))
        this.GOOD_ARRAY <- ([| this.GOOD |] : Group[])
        this.ENEMY_ARRAY <- ([| this.ENEMY |] : Group[])
        this.ENEMY_ON_LEVEL_ARRAY <- ([| this.ENEMY; this.ENEMY_ON_LEVEL |] : Group[])
        this.NONE_ARRAY <- ([| this.NONE |] : Group[])
        ()
    
    static member getInstance() : BasicGroupFactory =
        if (JR.same(BasicGroupFactory.instance, NullUtil.getInstance().NULL_OBJECT)) then
            BasicGroupFactory.instance <- (new BasicGroupFactory())
        (box (BasicGroupFactory.instance) :?> BasicGroupFactory)


