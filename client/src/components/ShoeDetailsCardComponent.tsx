import { Shoe } from "../types/Shoe";

const ShoeDetailsCardComponent = ({ shoe }: { shoe: Shoe | undefined }) => {
    const isInvalidShoe = Array.isArray(shoe) && shoe[0] === "Could not find shoe";
    console.log(shoe);
    return (
        <div>
            {!shoe || isInvalidShoe ?
            (
                <div className="noShoes">No shoe found.</div>
            ) 
            :
            (

                <div className="shoeCardDetail">
                    <img src={shoe.imageUrl} alt={shoe.name} className="shoeImage" />
                
                        <div className="shoeInfo">
                            <h3 className="shoeName">{shoe.name}</h3>
                            <p className="shoeBrand">{shoe.shoeBrandName} • {shoe.shoeCategoryName}</p>
                        </div>

                            <p className="shoeDescription">{shoe.description}</p>

                        <div className="shoeDetails">
                            <span className="shoePrice">${shoe.price.toFixed(2)}</span>
                            <span className="shoeSize">Size: {shoe.size}</span>
                        </div>

                        <button className="buyButton">Buy Now</button>
                </div>

            )} 
        </div>

    );
  };
  
  export default ShoeDetailsCardComponent;