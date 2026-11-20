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
type LineAnimation =
    inherit Animation
    [<DefaultValue(false)>] val mutable newLine : int[][]
    [<DefaultValue(false)>] val mutable tempLine : int[][]
    [<DefaultValue(false)>] val mutable line : int[][]
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LineAnimation.jclinitDone then
            LineAnimation.jclinitDone <- true
            LineAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_LineAnimation() : unit =
        this.newLine <- (JR.newArray2<int>(2, 2))
        this.tempLine <- NullUtil.getInstance().NULL_INT_ARRAY_ARRAY
        this.line <- (JR.newArray2<int>(2, 2))
        ()
    
    new (basicColor: BasicColor) as this =
        { inherit Animation() }
        then
            this.jfields_LineAnimation()
            this.jctor1(basicColor)
    member this.jctor1(basicColor: BasicColor) : unit =
        this.setBasicColorP(basicColor)
        ()
    
    abstract init : x: int * y: int -> unit
    default this.init(x: int, y: int) : unit =
        this.newLine.[0].[0] <- x
        this.newLine.[0].[1] <- y
        this.newLine.[1].[0] <- x
        this.newLine.[1].[1] <- y
        this.tempLine <- this.line
        this.line <- this.newLine
        this.newLine <- this.tempLine
    
    abstract setPosition : x: int * y: int * z: int -> unit
    default this.setPosition(x: int, y: int, z: int) : unit =
        this.newLine.[0].[0] <- this.line.[1].[0]
        this.newLine.[0].[1] <- this.line.[1].[1]
        this.newLine.[1].[0] <- x
        this.newLine.[1].[1] <- y
        this.tempLine <- this.line
        this.line <- this.newLine
        this.newLine <- this.tempLine
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        let mutable currentLine : int[][] = this.line
        this.basicSetColorUtil.setBasicColorP3(graphics, this.getBasicColorP(), this.getColor())
        graphics.drawLine(currentLine.[0].[0], currentLine.[0].[1], currentLine.[1].[0], currentLine.[1].[1])
    
    override this.nextFrame() : unit =
        ()
    
    override this.getBasicColorP() : BasicColor =
        base.getBasicColorP()
    
    override this.setBasicColorP(basicColor: BasicColor) : unit =
        base.setBasicColorP(basicColor)
    interface ColorCompositeInterface with
        member this.getBasicColorP() : BasicColor = this.getBasicColorP()
    interface PositionInterface with
        member this.setPosition(jp0: int, jp1: int, jp2: int) : unit = this.setPosition(jp0, jp1, jp2)
    interface BasicColorCompositeSetterInterface with
        member this.setBasicColorP(jp0: BasicColor) : unit = this.setBasicColorP(jp0)


