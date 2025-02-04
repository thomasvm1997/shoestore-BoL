import { Shoe } from "../types/Shoe";

const ShoeDetailsCardComponent = ({ shoe }: { shoe: Shoe | undefined }) => {

    return (
        <div className="cardsContainer">
            {shoe != undefined ? 
            (

                    <div className="shoeCard" key={shoe.id}>
                        <p>{shoe.shoeBrandName}</p>
                        <h3>{shoe.name}</h3>
                        <img src={shoe.imageUrl} alt={shoe.name} className="shoeImage" />
                        <span>{shoe.price.toFixed(2)}</span>
                    </div>

            ) 
            : 
            (
                <div className="noShoes">No shoe found.</div>
            )}
        </div>

    );
  };
  
  export default ShoeDetailsCardComponent;