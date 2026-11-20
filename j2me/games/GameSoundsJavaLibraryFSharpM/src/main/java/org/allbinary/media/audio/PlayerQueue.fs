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
type PlayerQueue =
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] val mutable max : int
    static member TOTAL : string = "Sounds In Queue: "
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PlayerQueue.jclinitDone then
            PlayerQueue.jclinitDone <- true
            PlayerQueue.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_PlayerQueue() : unit =
        this.commonStrings <- CommonStrings.getInstance()
        this.list <- (new BasicArrayListD())
        ()
    
    new (max_: int) as this =
        {  }
        then
            this.jfields_PlayerQueue()
            this.jctor1(max_)
    member this.jctor1(max_: int) : unit =
        this.max <- max_
        ()
    
    abstract add : sound: Sound -> unit
    default this.add(sound: Sound) : unit =
        try
            if not (this.list.contains(sound)) then
                ignore (this.list.add(sound))
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                PreLogUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.ADD)
            | _ -> reraise ()
    
    abstract process_ : unit -> bool
    default this.process_() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable sound : Sound = NoSound.getInstance()
        try
            let mutable played : bool = false
            if this.list.size() > 0 then
                sound <- (box (this.list.removeAt(0)) :?> Sound)
                if not (JR.same(sound, null)) then
                    sound.getPlayerP().start()
                while this.list.size() > this.max do
                    ignore (this.list.removeAt(0))
                played <- true
            jret <- played
            jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable resource : string = StringUtil.getInstance().EMPTY_STRING
                if not (JR.same(sound, null)) then
                    resource <- sound.getResource()
                PreLogUtil.put((new StringMaker()).append(this.commonStrings.EXCEPTION_LABEL).append(resource).ToString(), this, this.commonStrings.PROCESS)
                jret <- false
                jflow <- 1
            | _ -> reraise ()
        jret
    
    abstract clear : unit -> unit
    default this.clear() : unit =
        this.list.clear()
    
    override this.ToString() : string =
        (new StringMaker()).append(PlayerQueue.TOTAL).appendint(this.list.size()).ToString()


