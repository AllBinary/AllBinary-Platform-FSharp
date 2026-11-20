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
type Life =
    [<DefaultValue(false)>] val mutable lives : int16
    [<DefaultValue(false)>] val mutable startLives : int16
    [<DefaultValue(false)>] val mutable maxlives : int16
    [<DefaultValue(false)>] static val mutable private jcell_NO_LIFE : Life
    static member NO_LIFE with get() : Life = (Life.jclinit(); Life.jcell_NO_LIFE) and set (jvalue: Life) = (Life.jclinit(); Life.jcell_NO_LIFE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Life.jclinitDone then
            Life.jclinitDone <- true
            Life.jclinitBody()
    static member private jclinitBody() : unit =
        Life.jcell_NO_LIFE <- Life.createLife()
        ()
    
    static member createLife() : Life =
        let mutable jflow = 0
        let mutable jret : Life = Unchecked.defaultof<Life>
        try
            jret <- (new Life(int16 (0), int16 (0)))
            jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                raise ((new JRuntimeException()))
            | _ -> reraise ()
        jret
    
    new (lives: int16, maxlives: int16) as this =
        {  }
        then
            this.jctor1(lives, maxlives)
    member this.jctor1(lives: int16, maxlives: int16) : unit =
        this.maxlives <- maxlives
        if lives > this.maxlives then
            raise ((new JException("To Many Lives")))
        this.lives <- lives
        this.startLives <- lives
        ()
    
    abstract get : unit -> int16
    default this.get() : int16 =
        this.lives
    
    abstract set : lives: int16 -> unit
    default this.set(lives: int16) : unit =
        this.lives <- lives
    
    abstract reset : unit -> unit
    default this.reset() : unit =
        this.lives <- this.startLives
    
    abstract add : lives: int16 -> unit
    default this.add(lives: int16) : unit =
        if not (this.reachedLimit()) then
            if (int (this.lives) + int (lives)) <= int (int (this.getMaxlives())) then
                this.lives <- int16 ((int (this.lives) + int (lives)))
            else
                this.lives <- this.getMaxlives()
    
    abstract isAlive : unit -> bool
    default this.isAlive() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if int (int (this.lives)) <= 0 then
            jret <- false
            jflow <- 1
        else
            jret <- true
            jflow <- 1
        jret
    
    abstract getMaxlives : unit -> int16
    default this.getMaxlives() : int16 =
        this.maxlives
    
    member this.reachedLimit() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (this.lives > this.maxlives) || (int (int (this.lives)) < 0) then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret
    
    abstract deaths : lives: int16 -> unit
    default this.deaths(lives: int16) : unit =
        if not (this.reachedLimit()) then
            if (int (this.lives) - int (lives)) >= 0 then
                this.lives <- int16 ((int (this.lives) - int (lives)))
            else
                this.lives <- (0s)
    
    abstract getStartLives : unit -> int16
    default this.getStartLives() : int16 =
        this.startLives
    
    abstract setStartLives : startLives: int16 -> unit
    default this.setStartLives(startLives: int16) : unit =
        this.startLives <- startLives
    interface LifeInterface with
        member this.get() : int16 = this.get()
        member this.set(jp0: int16) : unit = this.set(jp0)
        member this.reset() : unit = this.reset()
        member this.add(jp0: int16) : unit = this.add(jp0)
        member this.deaths(jp0: int16) : unit = this.deaths(jp0)
        member this.getMaxlives() : int16 = this.getMaxlives()
        member this.isAlive() : bool = this.isAlive()


