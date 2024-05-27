import MainNavBar from "../../Components/main-nav-bar"
import Footer from "../../Components/Footer"
import './index.css'
import { ThemeProvider } from "@mui/material";
import { MainTheme } from "../../Assests/custom-styles";
import LineCharts from "../../Components/Charts/LineChart";

import AccountBalanceWalletOutlinedIcon from '@mui/icons-material/AccountBalanceWalletOutlined';
import StoreOutlinedIcon from '@mui/icons-material/StoreOutlined';
import ShoppingCartCheckoutOutlinedIcon from '@mui/icons-material/ShoppingCartCheckoutOutlined';

export default function Finances() {
    return (
        <>
            <ThemeProvider theme={MainTheme}>
                <MainNavBar />
                <div className="container">
                    <h4 className="main__header">MANAGE PERSONAL FINANCE</h4>
                    <div className="data_card__container">
                        <div className="data_card__1">
                            <p className="data_card__header">Annual Income</p>
                            <p className="data_card__content">$ 24,000.00</p>
                        </div>
                        <div className="data_card__2">
                            <p className="data_card__header">Monthly Income</p>
                            <p className="data_card__content">$ 24,000.00</p>
                        </div>
                        <div className="data_card__3">
                            <p className="data_card__header">Monthly Spendable Amount</p>
                            <p className="data_card__content">$ 24,000.00</p>
                        </div>
                        <div className="data_card__4">
                            <p className="data_card__header">Spendable Amount left</p>
                            <p className="data_card__content">$ 24,000.00</p>
                        </div>
                    </div>
                    <div className="sub__container">
                        <div className="data_card__5-1">
                            <div className="card__5_content">
                                <p className="card__5_heading">Income Goal</p>
                            </div>
                            <p className="card__5_heading">Income Source</p>
                            <div className="card__5_detail_list">
                                <div className="card__5_img_container">
                                    <AccountBalanceWalletOutlinedIcon color="primary" />
                                    <div className="card__5_img_container_details">
                                        <p className="card__5_img_container_details_heading">Salary</p>
                                        <p className="card__5_img_container_details_subheading">125k</p>
                                    </div>
                                </div>
                                <div className="card__5_img_container">
                                    <StoreOutlinedIcon color="primary" />
                                    <div className="card__5_img_container_details">
                                        <p className="card__5_img_container_details_heading">My Shop</p>
                                        <p className="card__5_img_container_details_subheading">125k</p>
                                    </div>
                                </div>
                                <div className="card__5_img_container">
                                    <ShoppingCartCheckoutOutlinedIcon color="primary" />
                                    <div className="card__5_img_container_details">
                                        <p className="card__5_img_container_details_heading">E-Commerce</p>
                                        <p className="card__5_img_container_details_subheading">125k</p>
                                    </div>
                                </div>
                            </div>

                        </div>
                        <div className="data_card__chart-2">
                            <LineCharts />
                        </div>
                    </div>
                </div>
                <Footer />
            </ThemeProvider>
        </>
    )
}