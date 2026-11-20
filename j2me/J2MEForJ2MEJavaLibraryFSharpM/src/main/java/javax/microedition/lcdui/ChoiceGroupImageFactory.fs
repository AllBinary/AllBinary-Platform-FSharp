namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type ChoiceGroupImageFactory =
    [<DefaultValue(false)>] val mutable multiOff : sbyte[]
    [<DefaultValue(false)>] val mutable multiOn : sbyte[]
    [<DefaultValue(false)>] val mutable radioOff : sbyte[]
    [<DefaultValue(false)>] val mutable radioOn : sbyte[]
    [<DefaultValue(false)>] val mutable midpUtil : MIDPUtil
    [<DefaultValue(false)>] val mutable imgMultiOffO : Image
    [<DefaultValue(false)>] val mutable imgMultiOnO : Image
    [<DefaultValue(false)>] val mutable imgRadioOffO : Image
    [<DefaultValue(false)>] val mutable imgRadioOnO : Image
    [<DefaultValue(false)>] val mutable imgMultiOff : Image
    [<DefaultValue(false)>] val mutable imgMultiOn : Image
    [<DefaultValue(false)>] val mutable imgRadioOff : Image
    [<DefaultValue(false)>] val mutable imgRadioOn : Image
    [<DefaultValue(false)>] val mutable imageArray : Image[]
    [<DefaultValue(false)>] static val mutable private jcell_instance : ChoiceGroupImageFactory
    static member instance with get() : ChoiceGroupImageFactory = (ChoiceGroupImageFactory.jclinit(); ChoiceGroupImageFactory.jcell_instance) and set (jvalue: ChoiceGroupImageFactory) = (ChoiceGroupImageFactory.jclinit(); ChoiceGroupImageFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ChoiceGroupImageFactory.jclinitDone then
            ChoiceGroupImageFactory.jclinitDone <- true
            ChoiceGroupImageFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ChoiceGroupImageFactory.jcell_instance <- (new ChoiceGroupImageFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_ChoiceGroupImageFactory()
    member this.jfields_ChoiceGroupImageFactory() : unit =
        this.multiOff <- ([| (-119y); (80y); (78y); (71y); (13y); (10y); (26y); (10y); (0y); (0y); (0y); (13y); (73y); (72y); (68y); (82y); (0y); (0y); (0y); (10y); (0y); (0y); (0y); (11y); (2y); (3y); (0y); (0y); (0y); (59y); (0y); (-12y); (-117y); (0y); (0y); (0y); (6y); (80y); (76y); (84y); (69y); (-1y); (-1y); (-1y); (-69y); (-69y); (-69y); (-57y); (75y); (-33y); (-8y); (0y); (0y); (0y); (30y); (73y); (68y); (65y); (84y); (120y); (-38y); (99y); (96y); (96y); (96y); (96y); (12y); (101y); (-8y); (-51y); (-32y); (-64y); (32y); (-64y); (-60y); (-64y); (-64y); (-128y); (11y); (51y); (-122y); (50y); (-4y); (6y); (0y); (63y); (116y); (3y); (1y); (53y); (-108y); (39y); (-26y); (0y); (0y); (0y); (0y); (73y); (69y); (78y); (68y); (-82y); (66y); (96y); (-126y) |] : sbyte[])
        this.multiOn <- ([| (-119y); (80y); (78y); (71y); (13y); (10y); (26y); (10y); (0y); (0y); (0y); (13y); (73y); (72y); (68y); (82y); (0y); (0y); (0y); (10y); (0y); (0y); (0y); (11y); (2y); (3y); (0y); (0y); (0y); (59y); (0y); (-12y); (-117y); (0y); (0y); (0y); (12y); (80y); (76y); (84y); (69y); (-1y); (-1y); (-1y); (-69y); (-69y); (-69y); (106y); (106y); (106y); (2y); (2y); (2y); (106y); (-103y); (14y); (-47y); (0y); (0y); (0y); (53y); (73y); (68y); (65y); (84y); (120y); (-38y); (99y); (96y); (96y); (124y); (-64y); (-16y); (-1y); (-77y); (3y); (-45y); (65y); (-111y); (15y); (76y); (12y); (108y); (12y); (76y); (12y); (-4y); (12y); (76y); (12y); (18y); (12y); (76y); (-68y); (127y); (24y); (-104y); (126y); (45y); (96y); (96y); (-7y); (-11y); (-109y); (-127y); (-23y); (-65y); (3y); (3y); (-29y); (127y); (-122y); (-113y); (0y); (5y); (37y); (12y); (-34y); (1y); (-99y); (-83y); (100y); (0y); (0y); (0y); (0y); (73y); (69y); (78y); (68y); (-82y); (66y); (96y); (-126y) |] : sbyte[])
        this.radioOff <- ([| (-119y); (80y); (78y); (71y); (13y); (10y); (26y); (10y); (0y); (0y); (0y); (13y); (73y); (72y); (68y); (82y); (0y); (0y); (0y); (11y); (0y); (0y); (0y); (11y); (2y); (3y); (0y); (0y); (0y); (-44y); (-62y); (-97y); (-75y); (0y); (0y); (0y); (9y); (80y); (76y); (84y); (69y); (-1y); (-1y); (-1y); (-69y); (-69y); (-69y); (106y); (106y); (106y); (-44y); (13y); (-1y); (-24y); (0y); (0y); (0y); (42y); (73y); (68y); (65y); (84y); (120y); (-38y); (99y); (96y); (90y); (-59y); (-64y); (32y); (-63y); (48y); (-127y); (65y); (-127y); (65y); (-127y); (41y); (-127y); (-31y); (5y); (19y); (3y); (3y); (3y); (50y); (102y); (80y); (96y); (80y); (96y); (-6y); (-63y); (80y); (-64y); (-64y); (-76y); (-118y); (1y); (0y); (113y); (24y); (5y); (61y); (73y); (-68y); (-100y); (98y); (0y); (0y); (0y); (0y); (73y); (69y); (78y); (68y); (-82y); (66y); (96y); (-126y) |] : sbyte[])
        this.radioOn <- ([| (-119y); (80y); (78y); (71y); (13y); (10y); (26y); (10y); (0y); (0y); (0y); (13y); (73y); (72y); (68y); (82y); (0y); (0y); (0y); (11y); (0y); (0y); (0y); (11y); (2y); (3y); (0y); (0y); (0y); (-44y); (-62y); (-97y); (-75y); (0y); (0y); (0y); (12y); (80y); (76y); (84y); (69y); (-1y); (-1y); (-1y); (-69y); (-69y); (-69y); (106y); (106y); (106y); (2y); (2y); (2y); (106y); (-103y); (14y); (-47y); (0y); (0y); (0y); (50y); (73y); (68y); (65y); (84y); (120y); (-38y); (5y); (-63y); (65y); (13y); (0y); (32y); (12y); (4y); (-63y); (-19y); (-11y); (-117y); (1y); (18y); (68y); (-100y); (10y); (52y); (19y); (94y); (72y); (64y); (17y); (101y); (-122y); (44y); (-44y); (-29y); (98y); (-52y); (89y); (77y); (-102y); (40y); (2y); (85y); (-95y); (-73y); (-63y); (-104y); (-63y); (37y); (-117y); (15y); (-40y); (119y); (10y); (41y); (78y); (26y); (-79y); (59y); (0y); (0y); (0y); (0y); (73y); (69y); (78y); (68y); (-82y); (66y); (96y); (-126y) |] : sbyte[])
        this.midpUtil <- MIDPUtil.getInstance()
        this.imgMultiOffO <- this.midpUtil.createImageFromByteArray(this.multiOff, 0, this.multiOff.Length)
        this.imgMultiOnO <- this.midpUtil.createImageFromByteArray(this.multiOn, 0, this.multiOn.Length)
        this.imgRadioOffO <- this.midpUtil.createImageFromByteArray(this.radioOff, 0, this.radioOff.Length)
        this.imgRadioOnO <- this.midpUtil.createImageFromByteArray(this.radioOn, 0, this.radioOn.Length)
        this.imgMultiOff <- this.imgMultiOffO
        this.imgMultiOn <- this.imgMultiOnO
        this.imgRadioOff <- this.imgRadioOffO
        this.imgRadioOn <- this.imgRadioOnO
        this.imageArray <- ([| this.imgMultiOff; this.imgMultiOn; this.imgRadioOff; this.imgRadioOn |] : Image[])
        ()
    
    static member getInstance() : ChoiceGroupImageFactory =
        ChoiceGroupImageFactory.instance
    
    abstract getImageArray : unit -> Image[]
    default this.getImageArray() : Image[] =
        this.imageArray
    
    abstract init : imageArray: Image[] -> unit
    default this.init(imageArray: Image[]) : unit =
        this.imgMultiOff <- imageArray.[0]
        this.imageArray.[0] <- this.imgMultiOff
        this.imgMultiOn <- imageArray.[1]
        this.imageArray.[1] <- this.imgMultiOn
        this.imgRadioOff <- imageArray.[2]
        this.imageArray.[2] <- this.imgRadioOff
        this.imgRadioOn <- imageArray.[3]
        this.imageArray.[3] <- this.imgRadioOn


