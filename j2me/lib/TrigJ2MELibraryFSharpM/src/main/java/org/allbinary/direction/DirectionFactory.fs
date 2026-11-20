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
type DirectionFactory =
    [<DefaultValue(false)>] val mutable NAME : string
    [<DefaultValue(false)>] val mutable LEFT : Direction
    [<DefaultValue(false)>] val mutable RIGHT : Direction
    [<DefaultValue(false)>] val mutable DOWN : Direction
    [<DefaultValue(false)>] val mutable UP : Direction
    [<DefaultValue(false)>] val mutable UP_LEFT : Direction
    [<DefaultValue(false)>] val mutable UP_RIGHT : Direction
    [<DefaultValue(false)>] val mutable DOWN_LEFT : Direction
    [<DefaultValue(false)>] val mutable DOWN_RIGHT : Direction
    [<DefaultValue(false)>] val mutable NOT_BORDERED_WITH : Direction
    [<DefaultValue(false)>] val mutable NO_DIRECTION : Direction
    [<DefaultValue(false)>] val mutable TOP : Direction
    [<DefaultValue(false)>] val mutable BOTTOM : Direction
    [<DefaultValue(false)>] val mutable ALL_DIRECTION : Direction
    [<DefaultValue(false)>] static val mutable private jcell_instance : DirectionFactory
    static member instance with get() : DirectionFactory = (DirectionFactory.jclinit(); DirectionFactory.jcell_instance) and set (jvalue: DirectionFactory) = (DirectionFactory.jclinit(); DirectionFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DirectionFactory.jclinitDone then
            DirectionFactory.jclinitDone <- true
            DirectionFactory.jclinitBody()
    static member private jclinitBody() : unit =
        DirectionFactory.jcell_instance <- (new DirectionFactory())
        ()
    member this.jfields_DirectionFactory() : unit =
        this.NAME <- "DIRECTION"
        this.LEFT <- (new Direction(CommonPhoneStrings.getInstance().LEFT, "WEST", 0, 1))
        this.RIGHT <- (new Direction(CommonPhoneStrings.getInstance().RIGHT, "EAST", 1, 0))
        this.DOWN <- (new Direction(CommonPhoneStrings.getInstance().DOWN, "SOUTH", 2, 0))
        this.UP <- (new Direction(CommonPhoneStrings.getInstance().UP, "NORTH", 3, 0))
        this.NOT_BORDERED_WITH <- (new Direction("NOT_BORDERED_WITH", "NOT_BORDERED_WITH", 8, 0))
        this.NO_DIRECTION <- (new Direction("NO_DIRECTION", "NO_DIRECTION", 9, 0))
        this.TOP <- (new Direction("TOP", "TOP", 10, 0))
        this.BOTTOM <- (new Direction("BOTTOM", "BOTTOM", 11, 0))
        this.ALL_DIRECTION <- (new Direction("ALL_DIRECTION", "ALL_DIRECTION", 12, 0))
        ()
    
    static member getInstance() : DirectionFactory =
        DirectionFactory.instance
    
    new () as this =
        {  }
        then
            this.jfields_DirectionFactory()
            this.jctor1()
    member this.jctor1() : unit =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        let mutable commonSeps : CommonSeps = CommonSeps.getInstance()
        this.UP_LEFT <- (new Direction("UP LEFT", stringBuffer.append(this.UP.getOtherName()).append(commonSeps.SPACE).append(this.LEFT.getOtherName()).ToString(), 4, 0))
        ignore (stringBuffer.delete(0, stringBuffer.length()))
        this.UP_RIGHT <- (new Direction("UP RIGHT", stringBuffer.append(this.UP.getOtherName()).append(commonSeps.SPACE).append(this.RIGHT.getOtherName()).ToString(), 5, 0))
        ignore (stringBuffer.delete(0, stringBuffer.length()))
        this.DOWN_LEFT <- (new Direction("DOWN LEFT", stringBuffer.append(this.DOWN.getOtherName()).append(commonSeps.SPACE).append(this.LEFT.getOtherName()).ToString(), 6, 0))
        ignore (stringBuffer.delete(0, stringBuffer.length()))
        this.DOWN_RIGHT <- (new Direction("DOWN RIGHT", stringBuffer.append(this.DOWN.getOtherName()).append(commonSeps.SPACE).append(this.RIGHT.getOtherName()).ToString(), 7, 0))
        ()


