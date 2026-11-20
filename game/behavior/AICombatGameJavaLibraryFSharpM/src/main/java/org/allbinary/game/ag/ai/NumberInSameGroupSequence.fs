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
type NumberInSameGroupSequence =
    [<DefaultValue(false)>] val mutable NUMBER_ON_SAME_TEAM_SEQUENCE_ZERO : Integer
    [<DefaultValue(false)>] val mutable NUMBER_ON_SAME_TEAM_SEQUENCE_ONE : Integer
    [<DefaultValue(false)>] val mutable NUMBER_ON_SAME_TEAM_SEQUENCE_TWO : Integer
    [<DefaultValue(false)>] val mutable NUMBER_ON_SAME_TEAM_SEQUENCE_THREE : Integer
    [<DefaultValue(false)>] val mutable NUMBER_ON_SAME_TEAM_SEQUENCE_FOUR : Integer
    [<DefaultValue(false)>] val mutable NUMBER_ON_SAME_TEAM_SEQUENCE_FIVE : Integer
    [<DefaultValue(false)>] val mutable NUMBER_ON_SAME_TEAM_SEQUENCE_SIX : Integer
    [<DefaultValue(false)>] val mutable NUMBER_ON_SAME_TEAM_SEQUENCE_SEVEN : Integer
    [<DefaultValue(false)>] val mutable NUMBER_ON_SAME_TEAM_SEQUENCE_EIGHT : Integer
    [<DefaultValue(false)>] val mutable NUMBER_ON_SAME_TEAM_SEQUENCE_NINE : Integer
    [<DefaultValue(false)>] val mutable NUMBER_ON_SAME_TEAM_SEQUENCE : Integer[]
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NumberInSameGroupSequence.jclinitDone then
            NumberInSameGroupSequence.jclinitDone <- true
            NumberInSameGroupSequence.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    static member getInstance() : NumberInSameGroupSequence =
        (new NumberInSameGroupSequence())
    
    new () as this =
        {  }
        then
            this.jctor1()
    member this.jctor1() : unit =
        let mutable smallIntegerSingletonFactory : SmallIntegerSingletonFactory = SmallIntegerSingletonFactory.getInstance()
        this.NUMBER_ON_SAME_TEAM_SEQUENCE_ZERO <- smallIntegerSingletonFactory.getAt(100)
        this.NUMBER_ON_SAME_TEAM_SEQUENCE_ONE <- smallIntegerSingletonFactory.getAt(101)
        this.NUMBER_ON_SAME_TEAM_SEQUENCE_TWO <- smallIntegerSingletonFactory.getAt(102)
        this.NUMBER_ON_SAME_TEAM_SEQUENCE_THREE <- smallIntegerSingletonFactory.getAt(103)
        this.NUMBER_ON_SAME_TEAM_SEQUENCE_FOUR <- smallIntegerSingletonFactory.getAt(104)
        this.NUMBER_ON_SAME_TEAM_SEQUENCE_FIVE <- smallIntegerSingletonFactory.getAt(105)
        this.NUMBER_ON_SAME_TEAM_SEQUENCE_SIX <- smallIntegerSingletonFactory.getAt(106)
        this.NUMBER_ON_SAME_TEAM_SEQUENCE_SEVEN <- smallIntegerSingletonFactory.getAt(107)
        this.NUMBER_ON_SAME_TEAM_SEQUENCE_EIGHT <- smallIntegerSingletonFactory.getAt(108)
        this.NUMBER_ON_SAME_TEAM_SEQUENCE_NINE <- smallIntegerSingletonFactory.getAt(109)
        this.NUMBER_ON_SAME_TEAM_SEQUENCE <- ([| this.NUMBER_ON_SAME_TEAM_SEQUENCE_ZERO; this.NUMBER_ON_SAME_TEAM_SEQUENCE_ONE; this.NUMBER_ON_SAME_TEAM_SEQUENCE_THREE; this.NUMBER_ON_SAME_TEAM_SEQUENCE_FOUR; this.NUMBER_ON_SAME_TEAM_SEQUENCE_FIVE; this.NUMBER_ON_SAME_TEAM_SEQUENCE_SIX; this.NUMBER_ON_SAME_TEAM_SEQUENCE_SEVEN; this.NUMBER_ON_SAME_TEAM_SEQUENCE_EIGHT; this.NUMBER_ON_SAME_TEAM_SEQUENCE_NINE |] : Integer[])
        ()


