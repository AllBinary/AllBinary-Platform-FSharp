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
type TouchButtonFactory =
    [<DefaultValue(false)>] val mutable LIST : BasicArrayList
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] val mutable savedList : BasicArrayList
    [<DefaultValue(false)>] val mutable saved : bool
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : TouchButtonFactory
    static member SINGLETON with get() : TouchButtonFactory = (TouchButtonFactory.jclinit(); TouchButtonFactory.jcell_SINGLETON) and set (jvalue: TouchButtonFactory) = (TouchButtonFactory.jclinit(); TouchButtonFactory.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TouchButtonFactory.jclinitDone then
            TouchButtonFactory.jclinitDone <- true
            TouchButtonFactory.jclinitBody()
    static member private jclinitBody() : unit =
        TouchButtonFactory.jcell_SINGLETON <- (new TouchButtonFactory())
        ()
    member this.jfields_TouchButtonFactory() : unit =
        this.LIST <- BasicArrayListUtil.getInstance().getImmutableInstance()
        this.list <- this.LIST
        this.savedList <- this.LIST
        this.saved <- false
        ()
    
    static member getInstance() : TouchButtonFactory =
        TouchButtonFactory.SINGLETON
    
    new () as this =
        {  }
        then
            this.jfields_TouchButtonFactory()
    
    abstract defaultList : unit -> unit
    default this.defaultList() : unit =
        this.list <- this.LIST
        this.toggle(false, this.LIST)
    
    abstract toggle : save: bool * list_: BasicArrayList -> unit
    default this.toggle(save: bool, list_: BasicArrayList) : unit =
        if not (JR.same(list_, BasicArrayListUtil.getInstance().getImmutableInstance())) then
            this.savedList <- list_
            if not (this.saved) then
                this.list <- this.savedList
        else
            if save then
                if not (this.saved) then
                    this.saved <- true
                    this.savedList <- this.list
                    this.list <- this.LIST
                else
                    ()
            else
                this.list <- this.savedList
                this.saved <- false
    
    abstract setList : list_: BasicArrayList -> unit
    default this.setList(list_: BasicArrayList) : unit =
        if (JR.same(list_, null)) then
            raise ((new JException("Null List")))
        this.list <- list_
    
    abstract getList : unit -> BasicArrayList
    default this.getList() : BasicArrayList =
        this.list


