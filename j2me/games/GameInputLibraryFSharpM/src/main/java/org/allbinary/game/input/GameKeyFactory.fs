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
type GameKeyFactory =
    [<DefaultValue(false)>] val mutable NONE : GameKey
    [<DefaultValue(false)>] val mutable UP : GameKey
    [<DefaultValue(false)>] val mutable DOWN : GameKey
    [<DefaultValue(false)>] val mutable LEFT : GameKey
    [<DefaultValue(false)>] val mutable RIGHT : GameKey
    [<DefaultValue(false)>] val mutable KEY_POUND : GameKey
    [<DefaultValue(false)>] val mutable KEY_STAR : GameKey
    [<DefaultValue(false)>] val mutable KEY_NUM0 : GameKey
    [<DefaultValue(false)>] val mutable KEY_NUM1 : GameKey
    [<DefaultValue(false)>] val mutable KEY_NUM2 : GameKey
    [<DefaultValue(false)>] val mutable KEY_NUM3 : GameKey
    [<DefaultValue(false)>] val mutable KEY_NUM4 : GameKey
    [<DefaultValue(false)>] val mutable KEY_NUM5 : GameKey
    [<DefaultValue(false)>] val mutable KEY_NUM6 : GameKey
    [<DefaultValue(false)>] val mutable KEY_NUM7 : GameKey
    [<DefaultValue(false)>] val mutable KEY_NUM8 : GameKey
    [<DefaultValue(false)>] val mutable KEY_NUM9 : GameKey
    [<DefaultValue(false)>] val mutable GAME_A : GameKey
    [<DefaultValue(false)>] val mutable GAME_B : GameKey
    [<DefaultValue(false)>] val mutable GAME_C : GameKey
    [<DefaultValue(false)>] val mutable GAME_D : GameKey
    [<DefaultValue(false)>] val mutable FIRE : GameKey
    [<DefaultValue(false)>] val mutable LEVEL_DOWN : GameKey
    [<DefaultValue(false)>] val mutable LEVEL_UP : GameKey
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (GameKeyFactory.jclinit(); GameKeyFactory.jcell_instance) and set (jvalue: obj) = (GameKeyFactory.jclinit(); GameKeyFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameKeyFactory.jclinitDone then
            GameKeyFactory.jclinitDone <- true
            GameKeyFactory.jclinitBody()
    static member private jclinitBody() : unit =
        GameKeyFactory.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    new () as this =
        {  }
        then
            this.jfields_GameKeyFactory()
    member this.jfields_GameKeyFactory() : unit =
        this.NONE <- (new GameKey((InputFactory.getInstance().MAX - 1), "None"))
        this.UP <- (new GameKey(Canvas.UP, CommonPhoneStrings.getInstance().UP))
        this.DOWN <- (new GameKey(Canvas.DOWN, CommonPhoneStrings.getInstance().DOWN))
        this.LEFT <- (new GameKey(Canvas.LEFT, CommonPhoneStrings.getInstance().LEFT))
        this.RIGHT <- (new GameKey(Canvas.RIGHT, CommonPhoneStrings.getInstance().RIGHT))
        this.KEY_POUND <- (new GameKey(Canvas.KEY_POUND, "POUND"))
        this.KEY_STAR <- (new GameKey(Canvas.KEY_STAR, "STAR"))
        this.KEY_NUM0 <- (new GameKey(Canvas.KEY_NUM0, CommonPhoneStrings.getInstance().ZERO))
        this.KEY_NUM1 <- (new GameKey(Canvas.KEY_NUM1, CommonPhoneStrings.getInstance().ONE))
        this.KEY_NUM2 <- (new GameKey(Canvas.KEY_NUM2, CommonPhoneStrings.getInstance().TWO))
        this.KEY_NUM3 <- (new GameKey(Canvas.KEY_NUM3, CommonPhoneStrings.getInstance().THREE))
        this.KEY_NUM4 <- (new GameKey(Canvas.KEY_NUM4, CommonPhoneStrings.getInstance().FOUR))
        this.KEY_NUM5 <- (new GameKey(Canvas.KEY_NUM5, CommonPhoneStrings.getInstance().FIVE))
        this.KEY_NUM6 <- (new GameKey(Canvas.KEY_NUM6, CommonPhoneStrings.getInstance().SIX))
        this.KEY_NUM7 <- (new GameKey(Canvas.KEY_NUM7, CommonPhoneStrings.getInstance().SEVEN))
        this.KEY_NUM8 <- (new GameKey(Canvas.KEY_NUM8, CommonPhoneStrings.getInstance().EIGHT))
        this.KEY_NUM9 <- (new GameKey(Canvas.KEY_NUM9, CommonPhoneStrings.getInstance().NINE))
        this.GAME_A <- (new GameKey(Canvas.GAME_A, "Game A"))
        this.GAME_B <- (new GameKey(Canvas.GAME_B, "Game B"))
        this.GAME_C <- (new GameKey(Canvas.GAME_C, "Game C"))
        this.GAME_D <- (new GameKey(Canvas.GAME_D, "Game D"))
        this.FIRE <- (new GameKey(Canvas.FIRE, CommonPhoneStrings.getInstance().FIRE))
        this.LEVEL_DOWN <- (new GameKey((Canvas.KEY_NUM9 + 1), "Cheat Level Up"))
        this.LEVEL_UP <- (new GameKey((Canvas.KEY_NUM9 + 2), "Cheat Level Down"))
        ()
    
    static member getInstance() : GameKeyFactory =
        if (JR.same(GameKeyFactory.instance, NullUtil.getInstance().NULL_OBJECT)) then
            GameKeyFactory.instance <- (new GameKeyFactory())
        (box (GameKeyFactory.instance) :?> GameKeyFactory)


