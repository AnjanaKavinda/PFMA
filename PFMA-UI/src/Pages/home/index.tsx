import { useState } from "react";
import MainNavBar from "../../Components/main-nav-bar"
import Footer from "../../Components/Footer"
import './index.css'
import { ThemeProvider } from "@mui/material";
import { MainTheme } from "../../Assests/custom-styles";

import { InputLabel, MenuItem, FormControl } from '@mui/material';
import Select, { SelectChangeEvent } from '@mui/material/Select';

import Barchart from "../../Components/Charts/Barchart";
export default function Home() {
    const [datevalue, setdatevalue] = useState('20');

    const handleChange = (event: SelectChangeEvent) => {
        setdatevalue(event.target.value as string);
    };


    return (
        <>
            <ThemeProvider theme={MainTheme}>
                <MainNavBar />
                <div className="container">
                    <h4 className="main__header">Home</h4>
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
                        <div className="data_card__5">
                            <FormControl>
                                <InputLabel id="demo-simple-select-label">Range</InputLabel>
                                <Select
                                    labelId="demo-simple-select-label"
                                    id="demo-simple-select"
                                    value={datevalue}
                                    label="Date"
                                    onChange={handleChange}
                                >
                                    <MenuItem value={10}>Today</MenuItem>
                                    <MenuItem value={20}>Last 7 Days</MenuItem>
                                    <MenuItem value={30}>Last Month</MenuItem>
                                </Select>
                            </FormControl>
                            <div className="year_exp__container">
                                <p className="year_exp__heading">Yearly Expenses</p>
                                <p className="year_exp__cost">124,420.50</p>
                                <p className="year_exp__subtitle">Compared to last year <span className="year_exp__subtitle_success">3.5% Higher</span></p>
                            </div>
                            <div className="data_card__expenses_container">
                                <p>Food Expenses</p>
                                <p>$29,340.20</p>
                            </div>
                            <div className="data_card__expenses_container">
                                <p>Clothing </p>
                                <p>$29,340.20</p>
                            </div>
                        </div>
                        <div className="data_card__chart">
                            <Barchart />
                        </div>
                    </div>
                </div>
                <Footer />
            </ThemeProvider>
        </>
    )
}