import { Shoe } from "../types/Shoe";

const ShoeListCardComponent = ({ shoes }: { shoes: Shoe[] }) => {
    console.log(shoes)
    return (
        
        <div className="cardsContainer">
            {shoes.length > 0 ? 
            (
                shoes.map((shoe) => (
                    <div className="shoeCard" key={shoe.id}>
                        <p>{shoe.shoeBrandName}</p>
                        <h3>{shoe.name}</h3>
                        <img src={shoe.imageUrl} alt={shoe.name} className="shoeImage" />
                        <span>{shoe.price.toFixed(2)}</span>
                    </div>
                ))
                
            ) 
            : 
            (
                <div className="noShoes">No shoes found.</div>
            )}
        </div>
    );
  };
  
  export default ShoeListCardComponent;