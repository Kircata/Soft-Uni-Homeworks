package OneLevShop.Products;


import OneLevShop.AgeRestriction;

public abstract class ElectronicsProduct extends Product {
    private int guaranteePeriod;

    protected ElectronicsProduct(String name, double price, int quantity, AgeRestriction restriction, int guaranteePeriod) {
        super(name, price, quantity, restriction);

        this.setGuaranteePeriod(guaranteePeriod);
    }

    public int getGuaranteePeriod() {
        return guaranteePeriod;
    }

    private void setGuaranteePeriod(int guaranteePeriod) {
        this.guaranteePeriod = guaranteePeriod;
    }

    @Override
    public String toString() {
        StringBuilder result = new StringBuilder(super.toString());
        result.append(String.format("\tGuarantee (months): %d\n",this.getGuaranteePeriod()));
        return result.toString();
    }
}
