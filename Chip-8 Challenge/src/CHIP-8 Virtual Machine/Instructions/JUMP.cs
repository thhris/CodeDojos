namespace CHIP_8_Virtual_Machine.Instructions;
public class JUMP : AddressInstruction
{
    public override void Execute(VM vm)
    {
        vm.PC = Address;
    }

    public JUMP(TwelveBit address)
        : base(address) { }
}