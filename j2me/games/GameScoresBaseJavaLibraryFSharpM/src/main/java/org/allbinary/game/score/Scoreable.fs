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
type Scoreable =
    [<DefaultValue(false)>] val mutable points : int
    [<DefaultValue(false)>] static val mutable private jcell_ID : Integer
    static member ID with get() : Integer = (Scoreable.jclinit(); Scoreable.jcell_ID) and set (jvalue: Integer) = (Scoreable.jclinit(); Scoreable.jcell_ID <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Scoreable.jclinitDone then
            Scoreable.jclinitDone <- true
            Scoreable.jclinitBody()
    static member private jclinitBody() : unit =
        Scoreable.jcell_ID <- SmallIntegerSingletonFactory.getInstance().getAt(3)
        ()
    
    new (points: int) as this =
        {  }
        then
            this.jctor1(points)
    member this.jctor1(points: int) : unit =
        this.points <- points
        ()
    
    abstract addPoints : points: int -> unit
    default this.addPoints(points: int) : unit =
        this.points <- this.points + points
    
    abstract removePoints : points: int -> unit
    default this.removePoints(points: int) : unit =
        this.points <- this.points - points
    
    abstract setPoints : points: int -> unit
    default this.setPoints(points: int) : unit =
        this.points <- points
    
    abstract getPoints : unit -> int
    default this.getPoints() : int =
        this.points
    interface ScoreableInterface with
        member this.getPoints() : int = this.getPoints()
        member this.addPoints(jp0: int) : unit = this.addPoints(jp0)
        member this.removePoints(jp0: int) : unit = this.removePoints(jp0)


